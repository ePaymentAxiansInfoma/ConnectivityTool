using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Security.Cryptography;

namespace ePaymentRequest
{
    internal class RequestManager
    {
        private const string postSetExpressCheckout = "METHOD=SetExpressCheckout&APPCODE={0}&RETURNURL={1}&CANCELURL={2}&DESC={3}&NOTIFYURL={4}&ERRORURL={5}&EXTERNALDOCNO={6}&NOREDIRECT={7}&ISTEST=1";
        private const string postGetExpressCheckoutVersion = "METHOD=GetExpressCheckoutVersion&APPCODE={0}";
        private const string postGetExpressCheckoutState = "METHOD=GetExpressCheckoutState&APPCODE={0}&TOKEN={1}&VERSION={2}";
        private const string postGetProviders = "APPCODE={0}&COMMUNE={1}";

        private readonly string _url;
        private readonly string _code;
        private readonly string _psk;
        private readonly string _tenant;

        internal class PaymentLine
        {
            public string Decsription { get; set; }

            public string Amount { get; set; }
        }

        public RequestManager(string url, string tenant, string code, string psk)
        {
            _url = url;

            if (!_url.EndsWith("/"))
                _url += "/";
            _code = code;
            _psk = psk;
            _tenant = tenant;
        }

        private void CheckBaseInfos()
        {
            if (string.IsNullOrEmpty(_url))
                throw new Exception("Bitte geben Sie einen Url ein");

            if (string.IsNullOrEmpty(_tenant))
                throw new Exception("Bitte geben Sie einen Mandantenkürzel ein");

            if (string.IsNullOrEmpty(_code))
                throw new Exception("Bitte geben Sie einen Online Verfahren Code ein");

            if (string.IsNullOrEmpty(_psk))
                throw new Exception("Bitte geben Sie einen Online Verfahren PSK ein");


        }

        internal string SetExpressCheckout(string description, string externalDocNo, string totalAmount, string baseUrl, bool noRedirect, List<PaymentLine> lines)
        {
            CheckBaseInfos();

            if (!baseUrl.EndsWith("/"))
                baseUrl += "/";
            //The url to be notified on successful payments
            string returnUrl = string.Format("{0}Checkout/PaymentCheckoutOK", baseUrl);
            //The url to be notified on user cancel
            string cancelUrl = string.Format("{0}Checkout/PaymentCheckoutCancel", baseUrl);
            //The url to be notified on payments
            string notifyUrl = string.Format("{0}api/Config/NotifyPayment", baseUrl);
            //The url to be notified on errors
            string errorUrl = string.Format("{0}api/Config/ErrorPayment", baseUrl);

            if (string.IsNullOrEmpty(description))
                throw new Exception("Bitte geben Sie eine Beschreibung ein");

            description = HttpUtility.UrlEncode(description);

            string postData = string.Format(postSetExpressCheckout, _code, returnUrl, cancelUrl, description, notifyUrl, errorUrl, externalDocNo, noRedirect ? 1 : 0);

            decimal total = Convert.ToDecimal(totalAmount, CultureInfo.GetCultureInfo("en-US"));
            decimal lineTotal = 0m;

            string lineText = "&L_PAYMENTREQUEST_NAME_{0}={1}&L_PAYMENTREQUEST_AMT_{0}={2}";
            postData += string.Format("&AMT={0}", totalAmount.ToString(CultureInfo.GetCultureInfo("en-US")));

            int index = 0;
            foreach (var line in lines)
            {
                var tempAmount = Convert.ToDecimal(line.Amount, CultureInfo.GetCultureInfo("en-US"));
                lineTotal += tempAmount;
                postData += string.Format(lineText, index, HttpUtility.UrlEncode(line.Decsription), tempAmount.ToString(CultureInfo.GetCultureInfo("en-US")));
                index++;
            }

            if (total <= 0)
                throw new Exception("Der Betrag muss größer als Null sein");

            if (total != lineTotal)
                throw new Exception("Der Zeilenbetrag ist ungleich dem Gesamtbetrag");

            postData += string.Format("&A_PAYMENTREQUEST_ACCOUNT_0=1&A_PAYMENTREQUEST_ACCOUNT_1=3&A_PAYMENTREQUEST_ACCOUNT_2=4&A_PAYMENTREQUEST_ACCOUNT_3=5&A_PAYMENTREQUEST_ACCOUNT_4=8");
            NameValueCollection nvc = HttpUtility.ParseQueryString(postData);

            string value = string.Empty;
            foreach (string key in nvc.AllKeys)
                value += nvc.Get(key);

            postData += string.Format("&HASH={0}", CreateHash(value));

            Console.WriteLine("sendCheckoutRequest - postData: {0}", postData);

            HttpWebRequest webRequest = CreateWebRequest($"{_url}{_tenant}/pay/api/checkout/setexpresscheckout", postData);
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13;
            WriteData(webRequest, postData);
            string responseData = ReadData(webRequest);

            Console.WriteLine("sendCheckoutRequest - responseData: {0}", responseData);

            Dictionary<string, string> parameters = GetURLParameters(responseData);

            bool success = false;
            if (parameters.ContainsKey("ACK"))
            {
                if (parameters["ACK"].ToLower().Equals("success"))
                    success = true;
            }

            if (success)
            {
                if (parameters.ContainsKey("TOKEN"))
                {
                    return parameters["TOKEN"];
                }


            } 
            else
            {
                if (parameters.ContainsKey("ERROR"))
                    throw new Exception(parameters["ERROR"]);
            }
            return "";

        }

        internal string GetExpressCheckoutState(string token, string version)
        {
            CheckBaseInfos();


            if (string.IsNullOrEmpty(token))
                throw new Exception("Bitte geben Sie ein Token ein");

            string postData = string.Format(postGetExpressCheckoutState, _code, token, version);

            NameValueCollection nvc = HttpUtility.ParseQueryString(postData);
            string value = string.Empty;
            foreach (string key in nvc.AllKeys)
                value += nvc.Get(key);

            postData += string.Format("&HASH={0}", CreateHash(value));

            Console.WriteLine("sendCheckoutRequest - postData: {0}", postData);

            HttpWebRequest webRequest = CreateWebRequest($"{_url}{_tenant}/pay/api/checkout/GetExpressCheckoutState", postData);
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13;
            WriteData(webRequest, postData);
            string responseData = ReadData(webRequest);

            Console.WriteLine("sendCheckoutRequest - responseData: {0}", responseData);

            Dictionary<string, string> parameters = GetURLParameters(responseData);

            bool success = false;
            if (parameters.ContainsKey("ACK"))
            {
                if (parameters["ACK"].ToLower().Equals("success"))
                    success = true;
            }

            if (success)
            {
                if (parameters.ContainsKey("STATE"))
                {
                    return parameters["STATE"];
                }


            }
            else
            {
                if (parameters.ContainsKey("ERROR"))
                    throw new Exception(parameters["ERROR"]);
            }
            return "";

        }

        internal string GetExpressCheckoutVersion()
        {
            HttpWebRequest webRequest = CreateWebRequest($"{_url}{_tenant}/pay/api/checkout/GetExpressCheckoutVersion", "");
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13;
            WriteData(webRequest, "");
            return ReadData(webRequest);
        }

        internal void WriteData(HttpWebRequest webRequest, string postData)
        {
            using (Stream requestWriter = webRequest.GetRequestStream())
            {
                byte[] requestBytes = new UTF8Encoding().GetBytes(postData);
                requestWriter.Write(requestBytes, 0, requestBytes.Length);
            }
        }

        internal HttpWebRequest CreateWebRequest(string url, string postData)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";
            return webRequest;
        }

        internal string ReadData(HttpWebRequest webRequest)
        {
            string responseData = string.Empty;
            HttpWebResponse resp = (HttpWebResponse)webRequest.GetResponse();

            using (Stream responseReader = resp.GetResponseStream())
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    responseReader.CopyTo(ms);
                    ms.Position = 0;
                    responseData = new UTF8Encoding().GetString(ms.ToArray());
                }
            }
            return responseData;
        }

        private string CreateHash(string value)
        {
            HMACMD5 md5 = new HMACMD5((Encoding.UTF8.GetBytes(_psk)));
            byte[] computedHash = md5.ComputeHash(Encoding.UTF8.GetBytes(value));
            return BitConverter.ToString(computedHash).Replace("-", string.Empty);
        }

        private static Dictionary<string, string> GetURLParameters(string urlData)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            if (urlData == null)
                return result;

            string[] list = urlData.Split('&');

            foreach (string s in list)
            {
                string[] sublist = s.Split('=');
                if (sublist.Length == 2)
                {
                    string key = WebUtility.UrlEncode(sublist[0].ToUpper());
                    string value = WebUtility.UrlDecode(sublist[1]);

                    result.Add(key, value);
                }
            }
            return result;
        }
    }
}