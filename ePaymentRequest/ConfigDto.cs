namespace ePaymentRequest
{
    internal class ConfigDto
    {
        public string Url { get; set; }
        public string Tenant { get; set; }
        public string OriginCode { get; set; }
        public string Psk { get; set; }
        public string Description { get; set; }

        public string UrlPayment { get; set; }

        public string TotalAmount { get; set; }

        public string ExternalDocNo { get; set; }

        public bool NoRedirect { get; set; }

        public string BaseReturnUrl { get; set; }
    }
}
