namespace SekundarNovi
{
    partial class frmOsnovna
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPretraga = new System.Windows.Forms.TabPage();
            this.txtPodatakZaPretragu = new System.Windows.Forms.TextBox();
            this.cmbKolonaZaPretragu = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvtxtLBO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtJMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtBrojZK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sekundarDataSet = new SekundarNovi.SekundarDataSet();
            this.tabNovi = new System.Windows.Forms.TabPage();
            this.btnSnimiOsiguranika = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbPOO = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbOO = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbIspostava = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbFilijala = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.rbtNe = new System.Windows.Forms.RadioButton();
            this.rbtDa = new System.Windows.Forms.RadioButton();
            this.cmbDrzava = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbNaselje = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPol = new System.Windows.Forms.ComboBox();
            this.cmbOpstina = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUlicaiBroj = new System.Windows.Forms.TextBox();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.txtSrIme = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtLBO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrojZK = new System.Windows.Forms.TextBox();
            this.tabFaktura = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.fakdgvLek = new System.Windows.Forms.DataGridView();
            this.fakdgvMaterijal = new System.Windows.Forms.DataGridView();
            this.fakdgvUsluge = new System.Windows.Forms.DataGridView();
            this.fakcmbLekar = new System.Windows.Forms.ComboBox();
            this.label41 = new System.Windows.Forms.Label();
            this.fakcmbSluzba = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.fakcmbDodatnaD2 = new System.Windows.Forms.ComboBox();
            this.label45 = new System.Windows.Forms.Label();
            this.fakcmbDodatnaD1 = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.fakdtpDatumKraja = new System.Windows.Forms.DateTimePicker();
            this.fakcmbSluzbaOtp = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.fakcmbSluzbaPri = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.fakcmbZavrsnaDij = new System.Windows.Forms.ComboBox();
            this.fakcmbUputnaDij = new System.Windows.Forms.ComboBox();
            this.fakcmbVrstaLec = new System.Windows.Forms.ComboBox();
            this.fakcmbTipUsluge = new System.Windows.Forms.ComboBox();
            this.fakdtpDatumPoc = new System.Windows.Forms.DateTimePicker();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.fakcmbDrzava = new System.Windows.Forms.ComboBox();
            this.fakcmbIspostava = new System.Windows.Forms.ComboBox();
            this.fakcmbFilijala = new System.Windows.Forms.ComboBox();
            this.fakcmbOOP = new System.Windows.Forms.ComboBox();
            this.fakrdbKonvencijaNE = new System.Windows.Forms.RadioButton();
            this.fakrdbNosilacNE = new System.Windows.Forms.RadioButton();
            this.label44 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.fakrdbKonvencijaDA = new System.Windows.Forms.RadioButton();
            this.label29 = new System.Windows.Forms.Label();
            this.fakrdbNosilacDA = new System.Windows.Forms.RadioButton();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.faktxtOO = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.faktxtVrstaIspKonv = new System.Windows.Forms.TextBox();
            this.faktxtBrojIspKonv = new System.Windows.Forms.TextBox();
            this.faktxtNapomenaKonv = new System.Windows.Forms.TextBox();
            this.faktxtIme = new System.Windows.Forms.TextBox();
            this.faktxtPrezime = new System.Windows.Forms.TextBox();
            this.fadtxtJMBG = new System.Windows.Forms.TextBox();
            this.faktxtLBO = new System.Windows.Forms.TextBox();
            this.faktxtBrojZK = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.faktxtBrojKartona = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.oLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oLTableAdapter = new SekundarNovi.SekundarDataSetTableAdapters.OLTableAdapter();
            this.fakbtnSnimiFakturu = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPretraga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oLBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekundarDataSet)).BeginInit();
            this.tabNovi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabFaktura.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fakdgvLek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakdgvMaterijal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakdgvUsluge)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPretraga);
            this.tabControl1.Controls.Add(this.tabNovi);
            this.tabControl1.Controls.Add(this.tabFaktura);
            this.tabControl1.Location = new System.Drawing.Point(10, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1087, 691);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPretraga
            // 
            this.tabPretraga.Controls.Add(this.txtPodatakZaPretragu);
            this.tabPretraga.Controls.Add(this.cmbKolonaZaPretragu);
            this.tabPretraga.Controls.Add(this.label20);
            this.tabPretraga.Controls.Add(this.label19);
            this.tabPretraga.Controls.Add(this.dataGridView1);
            this.tabPretraga.Location = new System.Drawing.Point(4, 27);
            this.tabPretraga.Name = "tabPretraga";
            this.tabPretraga.Padding = new System.Windows.Forms.Padding(3);
            this.tabPretraga.Size = new System.Drawing.Size(1079, 660);
            this.tabPretraga.TabIndex = 0;
            this.tabPretraga.Text = "Pretraga";
            this.tabPretraga.UseVisualStyleBackColor = true;
            this.tabPretraga.Click += new System.EventHandler(this.tabPretraga_Click);
            // 
            // txtPodatakZaPretragu
            // 
            this.txtPodatakZaPretragu.Location = new System.Drawing.Point(602, 14);
            this.txtPodatakZaPretragu.Name = "txtPodatakZaPretragu";
            this.txtPodatakZaPretragu.Size = new System.Drawing.Size(314, 24);
            this.txtPodatakZaPretragu.TabIndex = 4;
            this.txtPodatakZaPretragu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPodatakZaPretragu_KeyDown);
            // 
            // cmbKolonaZaPretragu
            // 
            this.cmbKolonaZaPretragu.FormattingEnabled = true;
            this.cmbKolonaZaPretragu.Items.AddRange(new object[] {
            "LBO",
            "JMBG",
            "BROJZK",
            "Prezime"});
            this.cmbKolonaZaPretragu.Location = new System.Drawing.Point(133, 14);
            this.cmbKolonaZaPretragu.Name = "cmbKolonaZaPretragu";
            this.cmbKolonaZaPretragu.Size = new System.Drawing.Size(275, 26);
            this.cmbKolonaZaPretragu.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(440, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(156, 18);
            this.label20.TabIndex = 2;
            this.label20.Text = "Odgovarajući podatak:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(32, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 18);
            this.label19.TabIndex = 2;
            this.label19.Text = "Pronađi po ...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtLBO,
            this.dgvtxtJMBG,
            this.dgvtxtBrojZK,
            this.dgvtxtIme,
            this.dgvtxtPrezime});
            this.dataGridView1.DataSource = this.oLBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(960, 497);
            this.dataGridView1.TabIndex = 1;
            // 
            // dgvtxtLBO
            // 
            this.dgvtxtLBO.DataPropertyName = "LBO";
            this.dgvtxtLBO.HeaderText = "LBO";
            this.dgvtxtLBO.Name = "dgvtxtLBO";
            this.dgvtxtLBO.ReadOnly = true;
            // 
            // dgvtxtJMBG
            // 
            this.dgvtxtJMBG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvtxtJMBG.DataPropertyName = "JMBG";
            this.dgvtxtJMBG.HeaderText = "JMBG";
            this.dgvtxtJMBG.Name = "dgvtxtJMBG";
            this.dgvtxtJMBG.ReadOnly = true;
            this.dgvtxtJMBG.Width = 76;
            // 
            // dgvtxtBrojZK
            // 
            this.dgvtxtBrojZK.DataPropertyName = "BrojZK";
            this.dgvtxtBrojZK.HeaderText = "BrojZK";
            this.dgvtxtBrojZK.Name = "dgvtxtBrojZK";
            this.dgvtxtBrojZK.ReadOnly = true;
            // 
            // dgvtxtIme
            // 
            this.dgvtxtIme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvtxtIme.DataPropertyName = "Ime";
            this.dgvtxtIme.HeaderText = "Ime";
            this.dgvtxtIme.Name = "dgvtxtIme";
            this.dgvtxtIme.ReadOnly = true;
            // 
            // dgvtxtPrezime
            // 
            this.dgvtxtPrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvtxtPrezime.DataPropertyName = "Prezime";
            this.dgvtxtPrezime.HeaderText = "Prezime";
            this.dgvtxtPrezime.Name = "dgvtxtPrezime";
            this.dgvtxtPrezime.ReadOnly = true;
            // 
            // oLBindingSource1
            // 
            this.oLBindingSource1.DataMember = "OL";
            this.oLBindingSource1.DataSource = this.sekundarDataSet;
            // 
            // sekundarDataSet
            // 
            this.sekundarDataSet.DataSetName = "SekundarDataSet";
            this.sekundarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabNovi
            // 
            this.tabNovi.Controls.Add(this.btnSnimiOsiguranika);
            this.tabNovi.Controls.Add(this.groupBox1);
            this.tabNovi.Location = new System.Drawing.Point(4, 27);
            this.tabNovi.Name = "tabNovi";
            this.tabNovi.Size = new System.Drawing.Size(1079, 660);
            this.tabNovi.TabIndex = 2;
            this.tabNovi.Text = "Novi osiguranik";
            this.tabNovi.UseVisualStyleBackColor = true;
            this.tabNovi.Click += new System.EventHandler(this.tabNovi_Click);
            // 
            // btnSnimiOsiguranika
            // 
            this.btnSnimiOsiguranika.Location = new System.Drawing.Point(823, 467);
            this.btnSnimiOsiguranika.Name = "btnSnimiOsiguranika";
            this.btnSnimiOsiguranika.Size = new System.Drawing.Size(106, 30);
            this.btnSnimiOsiguranika.TabIndex = 1;
            this.btnSnimiOsiguranika.Text = "Snimi";
            this.btnSnimiOsiguranika.UseVisualStyleBackColor = true;
            this.btnSnimiOsiguranika.Click += new System.EventHandler(this.btnSnimiOsiguranika_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtpDatumRodjenja);
            this.groupBox1.Controls.Add(this.rbtNe);
            this.groupBox1.Controls.Add(this.rbtDa);
            this.groupBox1.Controls.Add(this.cmbDrzava);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbNaselje);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbPol);
            this.groupBox1.Controls.Add(this.cmbOpstina);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUlicaiBroj);
            this.groupBox1.Controls.Add(this.txtNapomena);
            this.groupBox1.Controls.Add(this.txtSrIme);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtJMBG);
            this.groupBox1.Controls.Add(this.txtLBO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBrojZK);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(161, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 497);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o osiguraniku";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbPOO);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.cmbOO);
            this.groupBox3.Location = new System.Drawing.Point(26, 388);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(581, 52);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Podatci o osiguranju";
            // 
            // cmbPOO
            // 
            this.cmbPOO.FormattingEnabled = true;
            this.cmbPOO.Location = new System.Drawing.Point(363, 21);
            this.cmbPOO.Name = "cmbPOO";
            this.cmbPOO.Size = new System.Drawing.Size(214, 24);
            this.cmbPOO.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(323, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 16);
            this.label17.TabIndex = 1;
            this.label17.Text = "POO";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 16);
            this.label16.TabIndex = 1;
            this.label16.Text = "OO";
            // 
            // cmbOO
            // 
            this.cmbOO.FormattingEnabled = true;
            this.cmbOO.Location = new System.Drawing.Point(54, 21);
            this.cmbOO.Name = "cmbOO";
            this.cmbOO.Size = new System.Drawing.Size(235, 24);
            this.cmbOO.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbIspostava);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cmbFilijala);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(26, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 49);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podatci o filijali";
            // 
            // cmbIspostava
            // 
            this.cmbIspostava.FormattingEnabled = true;
            this.cmbIspostava.Location = new System.Drawing.Point(363, 19);
            this.cmbIspostava.Name = "cmbIspostava";
            this.cmbIspostava.Size = new System.Drawing.Size(214, 24);
            this.cmbIspostava.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(295, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "Ispostava";
            // 
            // cmbFilijala
            // 
            this.cmbFilijala.FormattingEnabled = true;
            this.cmbFilijala.Location = new System.Drawing.Point(54, 19);
            this.cmbFilijala.Name = "cmbFilijala";
            this.cmbFilijala.Size = new System.Drawing.Size(235, 24);
            this.cmbFilijala.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Filijala";
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(398, 207);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(177, 22);
            this.dtpDatumRodjenja.TabIndex = 12;
            // 
            // rbtNe
            // 
            this.rbtNe.AutoSize = true;
            this.rbtNe.Location = new System.Drawing.Point(487, 130);
            this.rbtNe.Name = "rbtNe";
            this.rbtNe.Size = new System.Drawing.Size(44, 20);
            this.rbtNe.TabIndex = 4;
            this.rbtNe.TabStop = true;
            this.rbtNe.Text = "Ne";
            this.rbtNe.UseVisualStyleBackColor = true;
            // 
            // rbtDa
            // 
            this.rbtDa.AutoSize = true;
            this.rbtDa.Location = new System.Drawing.Point(398, 130);
            this.rbtDa.Name = "rbtDa";
            this.rbtDa.Size = new System.Drawing.Size(44, 20);
            this.rbtDa.TabIndex = 3;
            this.rbtDa.TabStop = true;
            this.rbtDa.Text = "Da";
            this.rbtDa.UseVisualStyleBackColor = true;
            // 
            // cmbDrzava
            // 
            this.cmbDrzava.FormattingEnabled = true;
            this.cmbDrzava.Location = new System.Drawing.Point(398, 157);
            this.cmbDrzava.Name = "cmbDrzava";
            this.cmbDrzava.Size = new System.Drawing.Size(177, 24);
            this.cmbDrzava.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(293, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Datum rođenja";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(337, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Država";
            // 
            // cmbNaselje
            // 
            this.cmbNaselje.FormattingEnabled = true;
            this.cmbNaselje.Location = new System.Drawing.Point(398, 69);
            this.cmbNaselje.Name = "cmbNaselje";
            this.cmbNaselje.Size = new System.Drawing.Size(177, 24);
            this.cmbNaselje.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(337, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Naselje";
            // 
            // cmbPol
            // 
            this.cmbPol.FormattingEnabled = true;
            this.cmbPol.Items.AddRange(new object[] {
            "M",
            "Z",
            "N"});
            this.cmbPol.Location = new System.Drawing.Point(83, 210);
            this.cmbPol.Name = "cmbPol";
            this.cmbPol.Size = new System.Drawing.Size(177, 24);
            this.cmbPol.TabIndex = 7;
            // 
            // cmbOpstina
            // 
            this.cmbOpstina.FormattingEnabled = true;
            this.cmbOpstina.Location = new System.Drawing.Point(398, 39);
            this.cmbOpstina.Name = "cmbOpstina";
            this.cmbOpstina.Size = new System.Drawing.Size(177, 24);
            this.cmbOpstina.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Opština";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(336, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nosilac";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Ulica i broj";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 256);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "Napomena";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(43, 213);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 16);
            this.label18.TabIndex = 1;
            this.label18.Text = "Pol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sr. ime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "JMBG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "LBO";
            // 
            // txtUlicaiBroj
            // 
            this.txtUlicaiBroj.Location = new System.Drawing.Point(398, 98);
            this.txtUlicaiBroj.Name = "txtUlicaiBroj";
            this.txtUlicaiBroj.Size = new System.Drawing.Size(177, 22);
            this.txtUlicaiBroj.TabIndex = 10;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(83, 253);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(492, 64);
            this.txtNapomena.TabIndex = 13;
            // 
            // txtSrIme
            // 
            this.txtSrIme.Location = new System.Drawing.Point(83, 182);
            this.txtSrIme.Name = "txtSrIme";
            this.txtSrIme.Size = new System.Drawing.Size(177, 22);
            this.txtSrIme.TabIndex = 6;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(83, 154);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(177, 22);
            this.txtIme.TabIndex = 5;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(83, 126);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(177, 22);
            this.txtPrezime.TabIndex = 4;
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(83, 98);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(177, 22);
            this.txtJMBG.TabIndex = 3;
            // 
            // txtLBO
            // 
            this.txtLBO.Location = new System.Drawing.Point(83, 70);
            this.txtLBO.Name = "txtLBO";
            this.txtLBO.Size = new System.Drawing.Size(177, 22);
            this.txtLBO.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Broj ZK";
            // 
            // txtBrojZK
            // 
            this.txtBrojZK.Location = new System.Drawing.Point(83, 39);
            this.txtBrojZK.Name = "txtBrojZK";
            this.txtBrojZK.Size = new System.Drawing.Size(177, 22);
            this.txtBrojZK.TabIndex = 1;
            // 
            // tabFaktura
            // 
            this.tabFaktura.Controls.Add(this.fakbtnSnimiFakturu);
            this.tabFaktura.Controls.Add(this.groupBox6);
            this.tabFaktura.Controls.Add(this.groupBox5);
            this.tabFaktura.Controls.Add(this.fakdtpDatumKraja);
            this.tabFaktura.Controls.Add(this.fakcmbSluzbaOtp);
            this.tabFaktura.Controls.Add(this.label47);
            this.tabFaktura.Controls.Add(this.fakcmbSluzbaPri);
            this.tabFaktura.Controls.Add(this.label46);
            this.tabFaktura.Controls.Add(this.fakcmbZavrsnaDij);
            this.tabFaktura.Controls.Add(this.fakcmbUputnaDij);
            this.tabFaktura.Controls.Add(this.fakcmbVrstaLec);
            this.tabFaktura.Controls.Add(this.fakcmbTipUsluge);
            this.tabFaktura.Controls.Add(this.fakdtpDatumPoc);
            this.tabFaktura.Controls.Add(this.label33);
            this.tabFaktura.Controls.Add(this.groupBox4);
            this.tabFaktura.Controls.Add(this.label38);
            this.tabFaktura.Controls.Add(this.label35);
            this.tabFaktura.Controls.Add(this.label37);
            this.tabFaktura.Controls.Add(this.label32);
            this.tabFaktura.Controls.Add(this.label34);
            this.tabFaktura.Controls.Add(this.faktxtBrojKartona);
            this.tabFaktura.Controls.Add(this.label36);
            this.tabFaktura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabFaktura.Location = new System.Drawing.Point(4, 27);
            this.tabFaktura.Name = "tabFaktura";
            this.tabFaktura.Padding = new System.Windows.Forms.Padding(3);
            this.tabFaktura.Size = new System.Drawing.Size(1079, 660);
            this.tabFaktura.TabIndex = 1;
            this.tabFaktura.Text = "Faktura";
            this.tabFaktura.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.fakdgvLek);
            this.groupBox6.Controls.Add(this.fakdgvMaterijal);
            this.groupBox6.Controls.Add(this.fakdgvUsluge);
            this.groupBox6.Controls.Add(this.fakcmbLekar);
            this.groupBox6.Controls.Add(this.label41);
            this.groupBox6.Controls.Add(this.fakcmbSluzba);
            this.groupBox6.Controls.Add(this.label40);
            this.groupBox6.Location = new System.Drawing.Point(6, 347);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1067, 313);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Podatci o uslugama";
            // 
            // fakdgvLek
            // 
            this.fakdgvLek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fakdgvLek.Location = new System.Drawing.Point(503, 197);
            this.fakdgvLek.Name = "fakdgvLek";
            this.fakdgvLek.Size = new System.Drawing.Size(482, 110);
            this.fakdgvLek.TabIndex = 1;
            // 
            // fakdgvMaterijal
            // 
            this.fakdgvMaterijal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fakdgvMaterijal.Location = new System.Drawing.Point(13, 197);
            this.fakdgvMaterijal.Name = "fakdgvMaterijal";
            this.fakdgvMaterijal.Size = new System.Drawing.Size(482, 110);
            this.fakdgvMaterijal.TabIndex = 1;
            // 
            // fakdgvUsluge
            // 
            this.fakdgvUsluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fakdgvUsluge.Location = new System.Drawing.Point(13, 43);
            this.fakdgvUsluge.Name = "fakdgvUsluge";
            this.fakdgvUsluge.Size = new System.Drawing.Size(972, 136);
            this.fakdgvUsluge.TabIndex = 5;
            // 
            // fakcmbLekar
            // 
            this.fakcmbLekar.FormattingEnabled = true;
            this.fakcmbLekar.Location = new System.Drawing.Point(664, 13);
            this.fakcmbLekar.Name = "fakcmbLekar";
            this.fakcmbLekar.Size = new System.Drawing.Size(321, 24);
            this.fakcmbLekar.TabIndex = 4;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(617, 13);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(42, 16);
            this.label41.TabIndex = 1;
            this.label41.Text = "Lekar";
            // 
            // fakcmbSluzba
            // 
            this.fakcmbSluzba.FormattingEnabled = true;
            this.fakcmbSluzba.Location = new System.Drawing.Point(194, 13);
            this.fakcmbSluzba.Name = "fakcmbSluzba";
            this.fakcmbSluzba.Size = new System.Drawing.Size(321, 24);
            this.fakcmbSluzba.TabIndex = 4;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(140, 13);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(49, 16);
            this.label40.TabIndex = 1;
            this.label40.Text = "Služba";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.fakcmbDodatnaD2);
            this.groupBox5.Controls.Add(this.label45);
            this.groupBox5.Controls.Add(this.fakcmbDodatnaD1);
            this.groupBox5.Controls.Add(this.label39);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox5.Location = new System.Drawing.Point(6, 299);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(957, 42);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dodatne dijagnoze";
            // 
            // fakcmbDodatnaD2
            // 
            this.fakcmbDodatnaD2.FormattingEnabled = true;
            this.fakcmbDodatnaD2.Location = new System.Drawing.Point(612, 15);
            this.fakcmbDodatnaD2.Name = "fakcmbDodatnaD2";
            this.fakcmbDodatnaD2.Size = new System.Drawing.Size(321, 24);
            this.fakcmbDodatnaD2.TabIndex = 4;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(581, 23);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(25, 16);
            this.label45.TabIndex = 1;
            this.label45.Text = "D2";
            // 
            // fakcmbDodatnaD1
            // 
            this.fakcmbDodatnaD1.FormattingEnabled = true;
            this.fakcmbDodatnaD1.Location = new System.Drawing.Point(142, 15);
            this.fakcmbDodatnaD1.Name = "fakcmbDodatnaD1";
            this.fakcmbDodatnaD1.Size = new System.Drawing.Size(321, 24);
            this.fakcmbDodatnaD1.TabIndex = 4;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(111, 23);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(25, 16);
            this.label39.TabIndex = 1;
            this.label39.Text = "D1";
            // 
            // fakdtpDatumKraja
            // 
            this.fakdtpDatumKraja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fakdtpDatumKraja.Location = new System.Drawing.Point(504, 189);
            this.fakdtpDatumKraja.Name = "fakdtpDatumKraja";
            this.fakdtpDatumKraja.Size = new System.Drawing.Size(120, 22);
            this.fakdtpDatumKraja.TabIndex = 1;
            // 
            // fakcmbSluzbaOtp
            // 
            this.fakcmbSluzbaOtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fakcmbSluzbaOtp.FormattingEnabled = true;
            this.fakcmbSluzbaOtp.Location = new System.Drawing.Point(773, 230);
            this.fakcmbSluzbaOtp.Name = "fakcmbSluzbaOtp";
            this.fakcmbSluzbaOtp.Size = new System.Drawing.Size(163, 24);
            this.fakcmbSluzbaOtp.TabIndex = 4;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label47.Location = new System.Drawing.Point(680, 235);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(88, 15);
            this.label47.TabIndex = 1;
            this.label47.Text = "Služba otpusta";
            // 
            // fakcmbSluzbaPri
            // 
            this.fakcmbSluzbaPri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fakcmbSluzbaPri.FormattingEnabled = true;
            this.fakcmbSluzbaPri.Location = new System.Drawing.Point(461, 230);
            this.fakcmbSluzbaPri.Name = "fakcmbSluzbaPri";
            this.fakcmbSluzbaPri.Size = new System.Drawing.Size(163, 24);
            this.fakcmbSluzbaPri.TabIndex = 4;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label46.Location = new System.Drawing.Point(365, 235);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(90, 15);
            this.label46.TabIndex = 1;
            this.label46.Text = "Služba prijema";
            // 
            // fakcmbZavrsnaDij
            // 
            this.fakcmbZavrsnaDij.FormattingEnabled = true;
            this.fakcmbZavrsnaDij.Location = new System.Drawing.Point(618, 267);
            this.fakcmbZavrsnaDij.Name = "fakcmbZavrsnaDij";
            this.fakcmbZavrsnaDij.Size = new System.Drawing.Size(321, 24);
            this.fakcmbZavrsnaDij.TabIndex = 4;
            // 
            // fakcmbUputnaDij
            // 
            this.fakcmbUputnaDij.FormattingEnabled = true;
            this.fakcmbUputnaDij.Location = new System.Drawing.Point(148, 267);
            this.fakcmbUputnaDij.Name = "fakcmbUputnaDij";
            this.fakcmbUputnaDij.Size = new System.Drawing.Size(321, 24);
            this.fakcmbUputnaDij.TabIndex = 4;
            // 
            // fakcmbVrstaLec
            // 
            this.fakcmbVrstaLec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fakcmbVrstaLec.FormattingEnabled = true;
            this.fakcmbVrstaLec.Location = new System.Drawing.Point(279, 230);
            this.fakcmbVrstaLec.Name = "fakcmbVrstaLec";
            this.fakcmbVrstaLec.Size = new System.Drawing.Size(76, 24);
            this.fakcmbVrstaLec.TabIndex = 4;
            // 
            // fakcmbTipUsluge
            // 
            this.fakcmbTipUsluge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fakcmbTipUsluge.FormattingEnabled = true;
            this.fakcmbTipUsluge.Location = new System.Drawing.Point(101, 230);
            this.fakcmbTipUsluge.Name = "fakcmbTipUsluge";
            this.fakcmbTipUsluge.Size = new System.Drawing.Size(76, 24);
            this.fakcmbTipUsluge.TabIndex = 4;
            // 
            // fakdtpDatumPoc
            // 
            this.fakdtpDatumPoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fakdtpDatumPoc.Location = new System.Drawing.Point(193, 189);
            this.fakdtpDatumPoc.Name = "fakdtpDatumPoc";
            this.fakdtpDatumPoc.Size = new System.Drawing.Size(120, 22);
            this.fakdtpDatumPoc.TabIndex = 1;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(344, 194);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(155, 16);
            this.label33.TabIndex = 1;
            this.label33.Text = "Datum završetka lečenja";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.fakcmbDrzava);
            this.groupBox4.Controls.Add(this.fakcmbIspostava);
            this.groupBox4.Controls.Add(this.fakcmbFilijala);
            this.groupBox4.Controls.Add(this.fakcmbOOP);
            this.groupBox4.Controls.Add(this.fakrdbKonvencijaNE);
            this.groupBox4.Controls.Add(this.fakrdbNosilacNE);
            this.groupBox4.Controls.Add(this.label44);
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.fakrdbKonvencijaDA);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.fakrdbNosilacDA);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.faktxtOO);
            this.groupBox4.Controls.Add(this.label43);
            this.groupBox4.Controls.Add(this.label42);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.faktxtVrstaIspKonv);
            this.groupBox4.Controls.Add(this.faktxtBrojIspKonv);
            this.groupBox4.Controls.Add(this.faktxtNapomenaKonv);
            this.groupBox4.Controls.Add(this.faktxtIme);
            this.groupBox4.Controls.Add(this.faktxtPrezime);
            this.groupBox4.Controls.Add(this.fadtxtJMBG);
            this.groupBox4.Controls.Add(this.faktxtLBO);
            this.groupBox4.Controls.Add(this.faktxtBrojZK);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(24, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(931, 168);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Podatci o osiguraniku";
            // 
            // fakcmbDrzava
            // 
            this.fakcmbDrzava.FormattingEnabled = true;
            this.fakcmbDrzava.Location = new System.Drawing.Point(705, 47);
            this.fakcmbDrzava.Name = "fakcmbDrzava";
            this.fakcmbDrzava.Size = new System.Drawing.Size(210, 24);
            this.fakcmbDrzava.TabIndex = 4;
            // 
            // fakcmbIspostava
            // 
            this.fakcmbIspostava.FormattingEnabled = true;
            this.fakcmbIspostava.Location = new System.Drawing.Point(437, 133);
            this.fakcmbIspostava.Name = "fakcmbIspostava";
            this.fakcmbIspostava.Size = new System.Drawing.Size(121, 24);
            this.fakcmbIspostava.TabIndex = 4;
            // 
            // fakcmbFilijala
            // 
            this.fakcmbFilijala.FormattingEnabled = true;
            this.fakcmbFilijala.Location = new System.Drawing.Point(437, 105);
            this.fakcmbFilijala.Name = "fakcmbFilijala";
            this.fakcmbFilijala.Size = new System.Drawing.Size(121, 24);
            this.fakcmbFilijala.TabIndex = 4;
            // 
            // fakcmbOOP
            // 
            this.fakcmbOOP.FormattingEnabled = true;
            this.fakcmbOOP.Location = new System.Drawing.Point(485, 77);
            this.fakcmbOOP.Name = "fakcmbOOP";
            this.fakcmbOOP.Size = new System.Drawing.Size(73, 24);
            this.fakcmbOOP.TabIndex = 4;
            // 
            // fakrdbKonvencijaNE
            // 
            this.fakrdbKonvencijaNE.AutoSize = true;
            this.fakrdbKonvencijaNE.Location = new System.Drawing.Point(871, 24);
            this.fakrdbKonvencijaNE.Name = "fakrdbKonvencijaNE";
            this.fakrdbKonvencijaNE.Size = new System.Drawing.Size(41, 20);
            this.fakrdbKonvencijaNE.TabIndex = 3;
            this.fakrdbKonvencijaNE.TabStop = true;
            this.fakrdbKonvencijaNE.Text = "ne";
            this.fakrdbKonvencijaNE.UseVisualStyleBackColor = true;
            // 
            // fakrdbNosilacNE
            // 
            this.fakrdbNosilacNE.AutoSize = true;
            this.fakrdbNosilacNE.Location = new System.Drawing.Point(517, 51);
            this.fakrdbNosilacNE.Name = "fakrdbNosilacNE";
            this.fakrdbNosilacNE.Size = new System.Drawing.Size(41, 20);
            this.fakrdbNosilacNE.TabIndex = 3;
            this.fakrdbNosilacNE.TabStop = true;
            this.fakrdbNosilacNE.Text = "ne";
            this.fakrdbNosilacNE.UseVisualStyleBackColor = true;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(652, 26);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(154, 16);
            this.label44.TabIndex = 1;
            this.label44.Text = "Osiguranik po konvenciji";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(614, 50);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(51, 16);
            this.label30.TabIndex = 1;
            this.label30.Text = "Država";
            // 
            // fakrdbKonvencijaDA
            // 
            this.fakrdbKonvencijaDA.AutoSize = true;
            this.fakrdbKonvencijaDA.Location = new System.Drawing.Point(819, 24);
            this.fakrdbKonvencijaDA.Name = "fakrdbKonvencijaDA";
            this.fakrdbKonvencijaDA.Size = new System.Drawing.Size(42, 20);
            this.fakrdbKonvencijaDA.TabIndex = 2;
            this.fakrdbKonvencijaDA.TabStop = true;
            this.fakrdbKonvencijaDA.Text = "da";
            this.fakrdbKonvencijaDA.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(366, 136);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(67, 16);
            this.label29.TabIndex = 1;
            this.label29.Text = "Ispostava";
            // 
            // fakrdbNosilacDA
            // 
            this.fakrdbNosilacDA.AutoSize = true;
            this.fakrdbNosilacDA.Location = new System.Drawing.Point(461, 51);
            this.fakrdbNosilacDA.Name = "fakrdbNosilacDA";
            this.fakrdbNosilacDA.Size = new System.Drawing.Size(42, 20);
            this.fakrdbNosilacDA.TabIndex = 2;
            this.fakrdbNosilacDA.TabStop = true;
            this.fakrdbNosilacDA.Text = "da";
            this.fakrdbNosilacDA.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(366, 108);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(47, 16);
            this.label28.TabIndex = 1;
            this.label28.Text = "Filijala";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(612, 83);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 16);
            this.label26.TabIndex = 1;
            this.label26.Text = "Vrsta isprave";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label27.Location = new System.Drawing.Point(287, 80);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(198, 15);
            this.label27.TabIndex = 1;
            this.label27.Text = "Osnov oslobađanja od participacije";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(614, 111);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(76, 16);
            this.label31.TabIndex = 1;
            this.label31.Text = "Napomena";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(27, 136);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(30, 16);
            this.label25.TabIndex = 1;
            this.label25.Text = "Ime";
            // 
            // faktxtOO
            // 
            this.faktxtOO.Location = new System.Drawing.Point(485, 24);
            this.faktxtOO.Name = "faktxtOO";
            this.faktxtOO.Size = new System.Drawing.Size(73, 22);
            this.faktxtOO.TabIndex = 0;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(364, 52);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(54, 16);
            this.label43.TabIndex = 1;
            this.label43.Text = "Nosilac";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(364, 27);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(113, 16);
            this.label42.TabIndex = 1;
            this.label42.Text = "Osnov osiguranja";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(0, 108);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(57, 16);
            this.label24.TabIndex = 1;
            this.label24.Text = "Prezime";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 80);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 16);
            this.label23.TabIndex = 1;
            this.label23.Text = "JMBG";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(23, 52);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 16);
            this.label22.TabIndex = 1;
            this.label22.Text = "LBO";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 16);
            this.label21.TabIndex = 1;
            this.label21.Text = "Broj ZK";
            // 
            // faktxtVrstaIspKonv
            // 
            this.faktxtVrstaIspKonv.Location = new System.Drawing.Point(705, 80);
            this.faktxtVrstaIspKonv.Name = "faktxtVrstaIspKonv";
            this.faktxtVrstaIspKonv.Size = new System.Drawing.Size(87, 22);
            this.faktxtVrstaIspKonv.TabIndex = 0;
            // 
            // faktxtBrojIspKonv
            // 
            this.faktxtBrojIspKonv.Location = new System.Drawing.Point(827, 80);
            this.faktxtBrojIspKonv.Name = "faktxtBrojIspKonv";
            this.faktxtBrojIspKonv.Size = new System.Drawing.Size(87, 22);
            this.faktxtBrojIspKonv.TabIndex = 0;
            // 
            // faktxtNapomenaKonv
            // 
            this.faktxtNapomenaKonv.Location = new System.Drawing.Point(704, 108);
            this.faktxtNapomenaKonv.Multiline = true;
            this.faktxtNapomenaKonv.Name = "faktxtNapomenaKonv";
            this.faktxtNapomenaKonv.Size = new System.Drawing.Size(211, 49);
            this.faktxtNapomenaKonv.TabIndex = 0;
            // 
            // faktxtIme
            // 
            this.faktxtIme.Location = new System.Drawing.Point(77, 133);
            this.faktxtIme.Name = "faktxtIme";
            this.faktxtIme.Size = new System.Drawing.Size(188, 22);
            this.faktxtIme.TabIndex = 0;
            // 
            // faktxtPrezime
            // 
            this.faktxtPrezime.Location = new System.Drawing.Point(77, 105);
            this.faktxtPrezime.Name = "faktxtPrezime";
            this.faktxtPrezime.Size = new System.Drawing.Size(188, 22);
            this.faktxtPrezime.TabIndex = 0;
            // 
            // fadtxtJMBG
            // 
            this.fadtxtJMBG.Location = new System.Drawing.Point(77, 77);
            this.fadtxtJMBG.Name = "fadtxtJMBG";
            this.fadtxtJMBG.Size = new System.Drawing.Size(188, 22);
            this.fadtxtJMBG.TabIndex = 0;
            // 
            // faktxtLBO
            // 
            this.faktxtLBO.Location = new System.Drawing.Point(77, 49);
            this.faktxtLBO.Name = "faktxtLBO";
            this.faktxtLBO.Size = new System.Drawing.Size(188, 22);
            this.faktxtLBO.TabIndex = 0;
            // 
            // faktxtBrojZK
            // 
            this.faktxtBrojZK.Location = new System.Drawing.Point(77, 21);
            this.faktxtBrojZK.Name = "faktxtBrojZK";
            this.faktxtBrojZK.Size = new System.Drawing.Size(188, 22);
            this.faktxtBrojZK.TabIndex = 0;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label38.Location = new System.Drawing.Point(493, 271);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(119, 16);
            this.label38.TabIndex = 1;
            this.label38.Text = "Završna dijagnoza";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label35.Location = new System.Drawing.Point(197, 234);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(77, 15);
            this.label35.TabIndex = 1;
            this.label35.Text = "Vrsta lečenja";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label37.Location = new System.Drawing.Point(29, 271);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(113, 16);
            this.label37.TabIndex = 1;
            this.label37.Text = "Uputna dijagnoza";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(43, 194);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(146, 16);
            this.label32.TabIndex = 1;
            this.label32.Text = "Datum početka lečenja";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label34.Location = new System.Drawing.Point(30, 234);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(64, 15);
            this.label34.TabIndex = 1;
            this.label34.Text = "Tip usluge";
            // 
            // faktxtBrojKartona
            // 
            this.faktxtBrojKartona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.faktxtBrojKartona.Location = new System.Drawing.Point(771, 191);
            this.faktxtBrojKartona.Name = "faktxtBrojKartona";
            this.faktxtBrojKartona.Size = new System.Drawing.Size(165, 22);
            this.faktxtBrojKartona.TabIndex = 0;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label36.Location = new System.Drawing.Point(686, 194);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(81, 16);
            this.label36.TabIndex = 1;
            this.label36.Text = "Broj Kartona";
            // 
            // oLBindingSource
            // 
            this.oLBindingSource.DataMember = "OL";
            this.oLBindingSource.DataSource = this.sekundarDataSet;
            // 
            // oLTableAdapter
            // 
            this.oLTableAdapter.ClearBeforeFill = true;
            // 
            // fakbtnSnimiFakturu
            // 
            this.fakbtnSnimiFakturu.Location = new System.Drawing.Point(961, 140);
            this.fakbtnSnimiFakturu.Name = "fakbtnSnimiFakturu";
            this.fakbtnSnimiFakturu.Size = new System.Drawing.Size(112, 34);
            this.fakbtnSnimiFakturu.TabIndex = 7;
            this.fakbtnSnimiFakturu.Text = "Snimi Fakturu";
            this.fakbtnSnimiFakturu.UseVisualStyleBackColor = true;
            this.fakbtnSnimiFakturu.Click += new System.EventHandler(this.fakbtnSnimiFakturu_Click);
            // 
            // frmOsnovna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 695);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOsnovna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOsnovna";
            this.Load += new System.EventHandler(this.frmOsnovna_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPretraga.ResumeLayout(false);
            this.tabPretraga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oLBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekundarDataSet)).EndInit();
            this.tabNovi.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabFaktura.ResumeLayout(false);
            this.tabFaktura.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fakdgvLek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakdgvMaterijal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakdgvUsluge)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oLBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPretraga;
        private System.Windows.Forms.TabPage tabFaktura;
        private System.Windows.Forms.TabPage tabNovi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrojZK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbPOO;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbOO;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbIspostava;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbFilijala;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.RadioButton rbtNe;
        private System.Windows.Forms.RadioButton rbtDa;
        private System.Windows.Forms.ComboBox cmbDrzava;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbNaselje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbOpstina;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUlicaiBroj;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.TextBox txtSrIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtLBO;
        private System.Windows.Forms.Button btnSnimiOsiguranika;
        private System.Windows.Forms.ComboBox cmbPol;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPodatakZaPretragu;
        private System.Windows.Forms.ComboBox cmbKolonaZaPretragu;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SekundarDataSet sekundarDataSet;
        private System.Windows.Forms.BindingSource oLBindingSource;
        private SekundarDataSetTableAdapters.OLTableAdapter oLTableAdapter;
        private System.Windows.Forms.BindingSource oLBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLBO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtJMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBrojZK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPrezime;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox fakcmbIspostava;
        private System.Windows.Forms.ComboBox fakcmbFilijala;
        private System.Windows.Forms.ComboBox fakcmbOOP;
        private System.Windows.Forms.RadioButton fakrdbNosilacNE;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.RadioButton fakrdbNosilacDA;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox faktxtBrojIspKonv;
        private System.Windows.Forms.TextBox faktxtIme;
        private System.Windows.Forms.TextBox faktxtPrezime;
        private System.Windows.Forms.TextBox fadtxtJMBG;
        private System.Windows.Forms.TextBox faktxtLBO;
        private System.Windows.Forms.TextBox faktxtBrojZK;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox fakcmbLekar;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox fakcmbSluzba;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox fakcmbDodatnaD1;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.DateTimePicker fakdtpDatumKraja;
        private System.Windows.Forms.ComboBox fakcmbZavrsnaDij;
        private System.Windows.Forms.ComboBox fakcmbUputnaDij;
        private System.Windows.Forms.ComboBox fakcmbVrstaLec;
        private System.Windows.Forms.ComboBox fakcmbTipUsluge;
        private System.Windows.Forms.DateTimePicker fakdtpDatumPoc;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox fakcmbDrzava;
        private System.Windows.Forms.RadioButton fakrdbKonvencijaNE;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.RadioButton fakrdbKonvencijaDA;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox faktxtVrstaIspKonv;
        private System.Windows.Forms.TextBox faktxtNapomenaKonv;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox faktxtBrojKartona;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.DataGridView fakdgvUsluge;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox faktxtOO;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ComboBox fakcmbDodatnaD2;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ComboBox fakcmbSluzbaOtp;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.ComboBox fakcmbSluzbaPri;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.DataGridView fakdgvLek;
        private System.Windows.Forms.DataGridView fakdgvMaterijal;
        private System.Windows.Forms.Button fakbtnSnimiFakturu;
    }
}