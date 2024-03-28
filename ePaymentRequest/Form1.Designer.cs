namespace ePaymentRequest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.tb_externaldocno = new System.Windows.Forms.TextBox();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_tenantID = new System.Windows.Forms.TextBox();
            this.tb_origincode = new System.Windows.Forms.TextBox();
            this.tb_psk = new System.Windows.Forms.TextBox();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demodatenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.katasterplanZahlungUndSollstellungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kITAGebührZahlungUndSollstellungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grundsteuerBAusgöeichVorhandenerPostenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zahlungPersistierenUndEigenenQRCodeVerwendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.loopThrough = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.returnUrl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DescColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.url_payment = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.statetoken = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.stateversion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.checkoutversion = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_desc
            // 
            this.tb_desc.Location = new System.Drawing.Point(131, 14);
            this.tb_desc.Margin = new System.Windows.Forms.Padding(2);
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(175, 20);
            this.tb_desc.TabIndex = 0;
            // 
            // tb_externaldocno
            // 
            this.tb_externaldocno.Location = new System.Drawing.Point(131, 35);
            this.tb_externaldocno.Margin = new System.Windows.Forms.Padding(2);
            this.tb_externaldocno.Name = "tb_externaldocno";
            this.tb_externaldocno.Size = new System.Drawing.Size(175, 20);
            this.tb_externaldocno.TabIndex = 1;
            // 
            // tb_amount
            // 
            this.tb_amount.Location = new System.Drawing.Point(131, 56);
            this.tb_amount.Margin = new System.Windows.Forms.Padding(2);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(175, 20);
            this.tb_amount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Beschreibung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Externe Belegnummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Betrag";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mandantenkürzel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Online Verfahren Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Online Verfahren PSK";
            // 
            // tb_tenantID
            // 
            this.tb_tenantID.Location = new System.Drawing.Point(128, 71);
            this.tb_tenantID.Margin = new System.Windows.Forms.Padding(2);
            this.tb_tenantID.Name = "tb_tenantID";
            this.tb_tenantID.Size = new System.Drawing.Size(175, 20);
            this.tb_tenantID.TabIndex = 13;
            this.tb_tenantID.Text = "";
            // 
            // tb_origincode
            // 
            this.tb_origincode.Location = new System.Drawing.Point(471, 49);
            this.tb_origincode.Margin = new System.Windows.Forms.Padding(2);
            this.tb_origincode.Name = "tb_origincode";
            this.tb_origincode.Size = new System.Drawing.Size(175, 20);
            this.tb_origincode.TabIndex = 14;
            this.tb_origincode.Text = "";
            // 
            // tb_psk
            // 
            this.tb_psk.Location = new System.Drawing.Point(471, 70);
            this.tb_psk.Margin = new System.Windows.Forms.Padding(2);
            this.tb_psk.Name = "tb_psk";
            this.tb_psk.Size = new System.Drawing.Size(175, 20);
            this.tb_psk.TabIndex = 15;
            this.tb_psk.Text = "";
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(127, 50);
            this.tb_url.Margin = new System.Windows.Forms.Padding(2);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(175, 20);
            this.tb_url.TabIndex = 25;
            this.tb_url.Text = "https://epayment-kommunal-test.azurewebsites.net/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "URL";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.demodatenToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(669, 24);
            this.menuStrip2.TabIndex = 28;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konfigurationToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // konfigurationToolStripMenuItem
            // 
            this.konfigurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speichernToolStripMenuItem,
            this.exportierenToolStripMenuItem});
            this.konfigurationToolStripMenuItem.Name = "konfigurationToolStripMenuItem";
            this.konfigurationToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.konfigurationToolStripMenuItem.Text = "Konfiguration";
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.speichernToolStripMenuItem.Text = "Importieren";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.SpeichernToolStripMenuItem_Click);
            // 
            // exportierenToolStripMenuItem
            // 
            this.exportierenToolStripMenuItem.Name = "exportierenToolStripMenuItem";
            this.exportierenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exportierenToolStripMenuItem.Text = "Exportieren";
            this.exportierenToolStripMenuItem.Click += new System.EventHandler(this.ExportierenToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.BeendenToolStripMenuItem_Click);
            // 
            // demodatenToolStripMenuItem
            // 
            this.demodatenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.katasterplanZahlungUndSollstellungToolStripMenuItem,
            this.kITAGebührZahlungUndSollstellungToolStripMenuItem,
            this.grundsteuerBAusgöeichVorhandenerPostenToolStripMenuItem,
            this.zahlungPersistierenUndEigenenQRCodeVerwendenToolStripMenuItem});
            this.demodatenToolStripMenuItem.Name = "demodatenToolStripMenuItem";
            this.demodatenToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.demodatenToolStripMenuItem.Text = "Demodaten";
            // 
            // katasterplanZahlungUndSollstellungToolStripMenuItem
            // 
            this.katasterplanZahlungUndSollstellungToolStripMenuItem.Name = "katasterplanZahlungUndSollstellungToolStripMenuItem";
            this.katasterplanZahlungUndSollstellungToolStripMenuItem.Size = new System.Drawing.Size(361, 22);
            this.katasterplanZahlungUndSollstellungToolStripMenuItem.Text = "Katasterplan (Zahlung und Sollstellung)";
            this.katasterplanZahlungUndSollstellungToolStripMenuItem.Click += new System.EventHandler(this.KatasterplanZahlungUndSollstellungToolStripMenuItem_Click);
            // 
            // kITAGebührZahlungUndSollstellungToolStripMenuItem
            // 
            this.kITAGebührZahlungUndSollstellungToolStripMenuItem.Name = "kITAGebührZahlungUndSollstellungToolStripMenuItem";
            this.kITAGebührZahlungUndSollstellungToolStripMenuItem.Size = new System.Drawing.Size(361, 22);
            this.kITAGebührZahlungUndSollstellungToolStripMenuItem.Text = "KITA-Gebühr (Zahlung und Sollstellung)";
            this.kITAGebührZahlungUndSollstellungToolStripMenuItem.Click += new System.EventHandler(this.KITAGebührZahlungUndSollstellungToolStripMenuItem_Click);
            // 
            // grundsteuerBAusgöeichVorhandenerPostenToolStripMenuItem
            // 
            this.grundsteuerBAusgöeichVorhandenerPostenToolStripMenuItem.Name = "grundsteuerBAusgöeichVorhandenerPostenToolStripMenuItem";
            this.grundsteuerBAusgöeichVorhandenerPostenToolStripMenuItem.Size = new System.Drawing.Size(361, 22);
            this.grundsteuerBAusgöeichVorhandenerPostenToolStripMenuItem.Text = "Grundsteuer B (Ausgöeich vorhandener Posten)";
            this.grundsteuerBAusgöeichVorhandenerPostenToolStripMenuItem.Click += new System.EventHandler(this.GrundsteuerBAusgöeichVorhandenerPostenToolStripMenuItem_Click);
            // 
            // zahlungPersistierenUndEigenenQRCodeVerwendenToolStripMenuItem
            // 
            this.zahlungPersistierenUndEigenenQRCodeVerwendenToolStripMenuItem.Name = "zahlungPersistierenUndEigenenQRCodeVerwendenToolStripMenuItem";
            this.zahlungPersistierenUndEigenenQRCodeVerwendenToolStripMenuItem.Size = new System.Drawing.Size(361, 22);
            this.zahlungPersistierenUndEigenenQRCodeVerwendenToolStripMenuItem.Text = "Zahlung persistieren und eigenen QR Code verwenden";
            this.zahlungPersistierenUndEigenenQRCodeVerwendenToolStripMenuItem.Click += new System.EventHandler(this.ZahlungPersistierenUndEigenenQRCodeVerwendenToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(20, 147);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(626, 302);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.loopThrough);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.returnUrl);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tb_desc);
            this.tabPage1.Controls.Add(this.tb_externaldocno);
            this.tabPage1.Controls.Add(this.tb_amount);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(618, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SetExpressCheckout";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(329, 38);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "No Redirect";
            // 
            // loopThrough
            // 
            this.loopThrough.AutoSize = true;
            this.loopThrough.Checked = true;
            this.loopThrough.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loopThrough.Location = new System.Drawing.Point(427, 39);
            this.loopThrough.Name = "loopThrough";
            this.loopThrough.Size = new System.Drawing.Size(15, 14);
            this.loopThrough.TabIndex = 14;
            this.loopThrough.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Return Url";
            // 
            // returnUrl
            // 
            this.returnUrl.Location = new System.Drawing.Point(427, 14);
            this.returnUrl.Margin = new System.Windows.Forms.Padding(2);
            this.returnUrl.Name = "returnUrl";
            this.returnUrl.Size = new System.Drawing.Size(175, 20);
            this.returnUrl.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Zeilen";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescColumn,
            this.AmountColumn});
            this.dataGridView1.Location = new System.Drawing.Point(17, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 129);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DescColumn
            // 
            this.DescColumn.Frozen = true;
            this.DescColumn.HeaderText = "Beschreibung";
            this.DescColumn.Name = "DescColumn";
            this.DescColumn.Width = 400;
            // 
            // AmountColumn
            // 
            this.AmountColumn.HeaderText = "Betrag";
            this.AmountColumn.Name = "AmountColumn";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(618, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GetAvailablePaymentProviders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.checkoutversion);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(618, 276);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "GetExpressCheckoutVersion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.stateversion);
            this.tabPage4.Controls.Add(this.statetoken);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(618, 276);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "GetExpressCheckoutState";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Senden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // url_payment
            // 
            this.url_payment.Location = new System.Drawing.Point(128, 95);
            this.url_payment.Margin = new System.Windows.Forms.Padding(2);
            this.url_payment.Name = "url_payment";
            this.url_payment.Size = new System.Drawing.Size(175, 20);
            this.url_payment.TabIndex = 31;
            this.url_payment.Text = "https://epayment-kommunal-test.azurewebsites.net/";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 98);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "URL Bezahlseite";
            // 
            // statetoken
            // 
            this.statetoken.AutoSize = true;
            this.statetoken.Location = new System.Drawing.Point(14, 17);
            this.statetoken.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statetoken.Name = "statetoken";
            this.statetoken.Size = new System.Drawing.Size(38, 13);
            this.statetoken.TabIndex = 9;
            this.statetoken.Text = "Token";
            this.statetoken.Click += new System.EventHandler(this.label12_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(421, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 41);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Version";
            // 
            // stateversion
            // 
            this.stateversion.Location = new System.Drawing.Point(131, 38);
            this.stateversion.Margin = new System.Windows.Forms.Padding(2);
            this.stateversion.Name = "stateversion";
            this.stateversion.Size = new System.Drawing.Size(175, 20);
            this.stateversion.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "State";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(131, 99);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 17);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Version";
            // 
            // checkoutversion
            // 
            this.checkoutversion.Enabled = false;
            this.checkoutversion.Location = new System.Drawing.Point(131, 14);
            this.checkoutversion.Margin = new System.Windows.Forms.Padding(2);
            this.checkoutversion.Name = "checkoutversion";
            this.checkoutversion.Size = new System.Drawing.Size(175, 20);
            this.checkoutversion.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 461);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.url_payment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_psk);
            this.Controls.Add(this.tb_origincode);
            this.Controls.Add(this.tb_tenantID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "ePayment ExpressCheckout Testtool";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.TextBox tb_externaldocno;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_tenantID;
        private System.Windows.Forms.TextBox tb_origincode;
        private System.Windows.Forms.TextBox tb_psk;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demodatenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem katasterplanZahlungUndSollstellungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kITAGebührZahlungUndSollstellungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grundsteuerBAusgöeichVorhandenerPostenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zahlungPersistierenUndEigenenQRCodeVerwendenToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox returnUrl;
        private System.Windows.Forms.TextBox url_payment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox loopThrough;
        private System.Windows.Forms.Label statetoken;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox stateversion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox checkoutversion;
    }
}