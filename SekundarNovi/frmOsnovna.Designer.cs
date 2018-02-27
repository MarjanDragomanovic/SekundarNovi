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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPretraga = new System.Windows.Forms.TabPage();
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
            this.tabControl1.SuspendLayout();
            this.tabNovi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(977, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPretraga
            // 
            this.tabPretraga.Location = new System.Drawing.Point(4, 27);
            this.tabPretraga.Name = "tabPretraga";
            this.tabPretraga.Padding = new System.Windows.Forms.Padding(3);
            this.tabPretraga.Size = new System.Drawing.Size(969, 530);
            this.tabPretraga.TabIndex = 0;
            this.tabPretraga.Text = "Pretraga";
            this.tabPretraga.UseVisualStyleBackColor = true;
            // 
            // tabNovi
            // 
            this.tabNovi.Controls.Add(this.btnSnimiOsiguranika);
            this.tabNovi.Controls.Add(this.groupBox1);
            this.tabNovi.Location = new System.Drawing.Point(4, 27);
            this.tabNovi.Name = "tabNovi";
            this.tabNovi.Size = new System.Drawing.Size(969, 530);
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
            this.groupBox1.Size = new System.Drawing.Size(626, 469);
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
            this.tabFaktura.Location = new System.Drawing.Point(4, 27);
            this.tabFaktura.Name = "tabFaktura";
            this.tabFaktura.Padding = new System.Windows.Forms.Padding(3);
            this.tabFaktura.Size = new System.Drawing.Size(969, 530);
            this.tabFaktura.TabIndex = 1;
            this.tabFaktura.Text = "Faktura";
            this.tabFaktura.UseVisualStyleBackColor = true;
            // 
            // frmOsnovna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 575);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOsnovna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOsnovna";
            this.Load += new System.EventHandler(this.frmOsnovna_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabNovi.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}