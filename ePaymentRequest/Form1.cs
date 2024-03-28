using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static ePaymentRequest.RequestManager;

namespace ePaymentRequest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        internal static string GetSHA256Managed(string value)
        {
            SHA256 mySHA256 = SHA256Managed.Create();
            byte[] computedHash = mySHA256.ComputeHash(Encoding.Unicode.GetBytes(value));



            string result = string.Empty;
            for (int i = 0; i < 32; i++)
            {
                byte b = (byte)computedHash.GetValue(i);
                result += b.ToString("x2");
            }



            return result;
        }



        private void SpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            long extdocno = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            double amount = rnd.Next(1, 99);

            OpenFileDialog filechooser = new OpenFileDialog
            {
                Title = "Import",
                Filter = "Json (*.json)|*.json"
            };
            // Show the OpenFileDialog and wait for user to close with OK 
            if (filechooser.ShowDialog() == DialogResult.OK)
            {
                // Check if the file exists before trying to open it 
                if (File.Exists(filechooser.FileName))
                {
                    // Enclose the streamreader in a using block to ensure proper closing and disposing
                    // of the file resource....
                    var configDto = JsonConvert.DeserializeObject<ConfigDto>(System.IO.File.ReadAllText(filechooser.FileName));
                    tb_url.Text = configDto.Url;
                    tb_tenantID.Text = configDto.Tenant;
                    tb_origincode.Text = configDto.OriginCode;
                    tb_psk.Text = configDto.Psk;
                    tb_desc.Text = configDto.Description;
                    tb_externaldocno.Text = extdocno.ToString();
                    tb_amount.Text = amount.ToString();
                    url_payment.Text = configDto.UrlPayment;
                    tb_amount.Text = configDto.TotalAmount.ToString();
                    loopThrough.Checked = configDto.NoRedirect;
                    returnUrl.Text = configDto.BaseReturnUrl;
                }
            }
        }

        private void ExportierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "Json (*.json)|*.json",
                Title = "Export"
            };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {

                ConfigDto config = new ConfigDto()
                {
                    Url = tb_url.Text,
                    Tenant = tb_tenantID.Text,
                    OriginCode = tb_origincode.Text,
                    Psk = tb_psk.Text,
                    Description = tb_desc.Text,
                    ExternalDocNo = tb_externaldocno.Text,
                    TotalAmount = tb_amount.Text,
                    UrlPayment = url_payment.Text,
                    NoRedirect = loopThrough.Checked,
                    BaseReturnUrl = returnUrl.Text
                };
                System.IO.File.WriteAllText(saveFile.FileName, JsonConvert.SerializeObject(config));
            }
        }

        private void BeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KatasterplanZahlungUndSollstellungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int extdocno = rnd.Next(1, 99999999);
            double amount = 12;

            tb_tenantID.Text = "";
            tb_origincode.Text = "SERVICEPORTAL";
            tb_psk.Text = "";
            tb_desc.Text = "Katasterplan";
            tb_externaldocno.Text = extdocno.ToString();
            tb_amount.Text = amount.ToString();
        }

        private void KITAGebührZahlungUndSollstellungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int extdocno = rnd.Next(1, 99999999);
            double amount = 250;

            tb_tenantID.Text = "";
            tb_origincode.Text = "SERVICEPORTAL";
            tb_psk.Text = "";
            tb_desc.Text = "KITA-Gebühr";
            tb_externaldocno.Text = extdocno.ToString();
            tb_amount.Text = amount.ToString();
        }

        private void GrundsteuerBAusgöeichVorhandenerPostenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string extdocno = "FAD-000048.100.2";
            string amount = "437.50";

            tb_tenantID.Text = "";
            tb_origincode.Text = "STEUER";
            tb_psk.Text = "";
            tb_desc.Text = "Grundsteuer B";
            tb_externaldocno.Text = extdocno;
            tb_amount.Text = amount.ToString();
        }

        private void ZahlungPersistierenUndEigenenQRCodeVerwendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int extdocno = rnd.Next(1, 99999999);
            double amount = 10;

            tb_tenantID.Text = "";
            tb_origincode.Text = "OWI";
            tb_psk.Text = "";
            tb_desc.Text = "Falschparken";
            tb_externaldocno.Text = extdocno.ToString();
            tb_amount.Text = amount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var requestManager = new RequestManager(tb_url.Text, tb_tenantID.Text, tb_origincode.Text, tb_psk.Text);
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    List<PaymentLine> lines = new List<PaymentLine>();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        PaymentLine line = new PaymentLine()
                        {
                            Decsription = $"{row.Cells[0].Value}",
                            Amount = $"{row.Cells[1].Value}"
                        };
                        if (string.IsNullOrEmpty(line.Decsription) || string.IsNullOrEmpty(line.Amount))
                            continue;
                        lines.Add(line);
                    }
                    try
                    {
                        string token = requestManager.SetExpressCheckout(tb_desc.Text, tb_externaldocno.Text, tb_amount.Text, returnUrl.Text, loopThrough.Checked, lines);
                        if (!string.IsNullOrEmpty(token))
                        {
                            string url = url_payment.Text;
                            if (!url.EndsWith("/"))
                                url += "/";
                            Process.Start("chrome", $"{url}?id={token}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Fehler");
                    }
                    break;
                case 2:
                    try
                    {
                        checkoutversion.Text = "";
                        string version = requestManager.GetExpressCheckoutVersion();
                        checkoutversion.Text = version;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Fehler");
                    }
                    break;
                case 3:
                    try
                    {
                        textBox2.Text = "";
                        string state = requestManager.GetExpressCheckoutState(textBox1.Text, stateversion.Text);
                        textBox2.Text = state;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Fehler");
                    }
                    break;
                case 4:

                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
