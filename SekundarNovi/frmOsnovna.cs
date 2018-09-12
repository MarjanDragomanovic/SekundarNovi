using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;

namespace SekundarNovi
{
    public partial class FrmOsnovna : Form
    {
        //int inSifra = 0;
        int inSifraEFOsiguranik = 0;
        int intID_Usluga = 0;
        int intID_SanMat = 0;
        //private decimal decCenaAUsluge;
        public string cena;
        SqlCommand cmd;

        public FrmOsnovna()
        {
            InitializeComponent();
            btnNoviOLFaktura.Visible = false;
        }

        private void BtnSnimiOsiguranika_Click(object sender, EventArgs e)
        {
            if (ValidateUnosNovogOL())
            {
                //int _Sifra = 0;
                //Kreiram konekciju
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    //Kreiram komandu i identifikujem je kao stored proceduru
                    using (SqlCommand sqlCommand = new SqlCommand("dbo.spNoviOL", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        //Add input parametre za stored proceduru i označi šta da se koristi kao vrednost
                        sqlCommand.Parameters.Add(new SqlParameter("@Sifra", SqlDbType.Int));
                        sqlCommand.Parameters["@Sifra"].Direction = ParameterDirection.Output;


                        sqlCommand.Parameters.Add(new SqlParameter("@Ime", SqlDbType.NVarChar, 50));
                        sqlCommand.Parameters["@Ime"].Value = txtIme.Text.Trim();
                        //sqlCommand.Parameters.Add(new SqlParameter("@Prezime", SqlDbType.NVarChar, 50));
                        //sqlCommand.Parameters["@Prezime"].Value = txtPrezime.Text;
                        sqlCommand.Parameters.AddWithValue("@Prezime", txtPrezime.Text.Trim());
                        sqlCommand.Parameters.Add(new SqlParameter("@Srednje_Ime", SqlDbType.NVarChar, 50));
                        sqlCommand.Parameters["@Srednje_Ime"].Value = txtSrIme.Text;
                        sqlCommand.Parameters.Add(new SqlParameter("@LBO", SqlDbType.BigInt));
                        sqlCommand.Parameters["@LBO"].Value = txtLBO.Text;
                        sqlCommand.Parameters.Add(new SqlParameter("@JMBG", SqlDbType.VarChar, 15));
                        sqlCommand.Parameters["@JMBG"].Value = txtJMBG.Text.Trim();
                        sqlCommand.Parameters.Add(new SqlParameter("@BrojZK", SqlDbType.VarChar, 11));
                        sqlCommand.Parameters["@BrojZK"].Value = txtBrojZK.Text.Trim();
                        sqlCommand.Parameters.Add(new SqlParameter("@Broj_kartona", SqlDbType.VarChar, 50));
                        sqlCommand.Parameters["@Broj_kartona"].Value = txtKarton.Text.Trim();
                        sqlCommand.Parameters.Add(new SqlParameter("@Pol", SqlDbType.VarChar, 1));
                        sqlCommand.Parameters["@Pol"].Value = cmbPol.SelectedValue;
                        sqlCommand.Parameters.Add(new SqlParameter("@Datum_Rodjenja", SqlDbType.DateTime, 8));
                        sqlCommand.Parameters["@Datum_Rodjenja"].Value = dtpDatumRodjenja.Value;
                        sqlCommand.Parameters.AddWithValue("@Je_nosilac", Convert.ToInt32(rbtDa.Checked ? 1 : 0));
                        sqlCommand.Parameters.Add(new SqlParameter("@Napomena", SqlDbType.NVarChar, 1000));
                        sqlCommand.Parameters["@Napomena"].Value = txtNapomena.Text;
                        sqlCommand.Parameters.Add(new SqlParameter("@Sifra_Filijala", SqlDbType.Int));
                        sqlCommand.Parameters["@Sifra_Filijala"].Value = cmbFilijala.SelectedValue;
                        sqlCommand.Parameters.Add(new SqlParameter("@Sifra_Ispostava", SqlDbType.Int));
                        sqlCommand.Parameters["@Sifra_Ispostava"].Value = cmbIspostava.SelectedValue;
                        sqlCommand.Parameters.Add(new SqlParameter("@Sifra_OO", SqlDbType.Int));
                        sqlCommand.Parameters["@Sifra_OO"].Value = cmbOO.SelectedValue;
                        sqlCommand.Parameters.Add(new SqlParameter("@Sifra_POO", SqlDbType.Int));
                        sqlCommand.Parameters["@Sifra_POO"].Value = cmbPOO.SelectedValue;
                        sqlCommand.Parameters.Add(new SqlParameter("@Sifra_drzava", SqlDbType.Int));
                        sqlCommand.Parameters["@Sifra_drzava"].Value = cmbDrzava.SelectedValue;

                        try
                        {
                            connection.Open();
                            //_Sifra = Convert.ToInt32(sqlCommand.ExecuteScalar());
                            sqlCommand.ExecuteNonQuery();
                        }
                        finally
                        {
                            connection.Close();
                            MessageBox.Show("Uspešno sačuvano...","Osiguranik");

                            faktxtBrojZK.Text = txtBrojZK.Text.ToString();
                            faktxtLBO.Text = txtLBO.Text;
                            faktxtJMBG.Text = txtJMBG.Text;
                            faktxtPrezime.Text = txtPrezime.Text;
                            faktxtIme.Text = txtIme.Text;
                            fakcmbOO.Text = cmbOO.Text;
                            fakcmbPOO.Text = cmbPOO.Text;
                            fakcmbFilijala.Text = cmbFilijala.Text;
                            fakcmbIspostava.Text = cmbIspostava.Text;

                            ClearNovogOL();
                            tabControl1.SelectedIndex = 2;

                            
                        }
                    }

                }

            }
        }

        bool ValidateUnosNovogOL()
        {
            bool _isValid = true;
            if (txtPrezime.Text.Trim() == "")
            {
                MessageBox.Show("Molim unesite prezime osiguranika...");
                _isValid = false;
            }

            // Ovde ostale validacije
            if (txtIme.Text.Trim() == "")
            {
                MessageBox.Show("Molim unesite ime osiguranika...");
                _isValid = false;
            }

            if (txtBrojZK.TextLength != 11)
            {
                MessageBox.Show("Broj ZK nema tačno 11 brojeva...");
                _isValid = false;
            }

            if (txtLBO.TextLength != 11)
            {
                MessageBox.Show("LBO nema tačno 11 brojeva...");
                _isValid = false;
            }

            if (txtJMBG.TextLength != 13)
            {
                MessageBox.Show("Broj ZK nema tačno 11 brojeva...");
                _isValid = false;
            }
            return _isValid;
        }

        void FilijalaCmbBoxFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ID, Naziv FROM Filijala", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Izaberi-";
                dtbl.Rows.InsertAt(topItem, 0);
                cmbFilijala.ValueMember = "ID";
                cmbFilijala.DisplayMember = "Naziv";
                cmbFilijala.DataSource = dtbl;

            }
        }

        void IspostavaCmbFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ID, Naziv FROM Ispostava", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Izaberi-";
                dtbl.Rows.InsertAt(topItem, 0);
                cmbIspostava.ValueMember = "ID";
                cmbIspostava.DisplayMember = "Naziv";
                cmbIspostava.DataSource = dtbl;

            }
        }

        void OOcmbFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Oznaka, Naziv FROM OO", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Izaberi-";
                dtbl.Rows.InsertAt(topItem, 0);
                cmbOO.ValueMember = "Oznaka";
                cmbOO.DisplayMember = "Naziv";
                cmbOO.DataSource = dtbl;

            }
        }

        void POOcmbFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Oznaka, Naziv FROM POO", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Izaberi-";
                dtbl.Rows.InsertAt(topItem, 0);
                cmbPOO.ValueMember = "Oznaka";
                cmbPOO.DisplayMember = "Naziv";
                cmbPOO.DataSource = dtbl;

            }
        }

        void DrzavacmbFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Sifra, Naziv FROM Drzava", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Izaberi-";
                dtbl.Rows.InsertAt(topItem, 0);
                cmbDrzava.ValueMember = "Sifra";
                cmbDrzava.DisplayMember = "Naziv";
                cmbDrzava.DataSource = dtbl;

            }
        }

        void ClearNovogOL()
        {
            txtBrojZK.Text = txtLBO.Text = txtJMBG.Text = txtPrezime.Text = txtIme.Text = txtSrIme.Text = txtNapomena.Text = "";
            cmbDrzava.SelectedIndex = cmbFilijala.SelectedIndex = cmbIspostava.SelectedIndex = cmbOO.SelectedIndex = cmbPOO.SelectedIndex = cmbPol.SelectedIndex = 0;
            dtpDatumRodjenja.Value = DateTime.Now;
        }

        private void LekarCmbBoxFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT LekarSekundar.ID_Lekar, PrezimeLekara FROM LekarSekundar INNER JOIN LekarZUstanova ON LekarSekundar.ID_Lekar = LekarZUstanova.ID_Lekar WHERE(LekarZUstanova.ID_ZU = 1003)", sqlCon);
                DataTable dtblLekar = new DataTable();
                sqlDa.Fill(dtblLekar);
                DataRow topItem = dtblLekar.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Izaberi-";
                dtblLekar.Rows.InsertAt(topItem, 0);
                fakcmbLekar.ValueMember = "ID_Lekar";
                fakcmbLekar.DisplayMember = "PrezimeLekara";
                cmbBoxIDLekar.DisplayMember = "ID_Lekar";
                fakcmbLekar.DataSource = dtblLekar;
                cmbBoxIDLekar.DataSource = dtblLekar;

            }
        }

        //void SluzbaCmbBoxFill()
        //{
        //    using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connString))
        //    {
        //        sqlCon.Open();
        //        SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Sifra, Naziv FROM SluzbaRZZO", sqlCon);
        //        DataTable dtbl = new DataTable();
        //        sqlDa.Fill(dtbl);
        //        DataRow topItem = dtbl.NewRow();
        //        topItem[0] = 0;
        //        topItem[1] = "-Izaberi-";
        //        dtbl.Rows.InsertAt(topItem, 0);
        //        dgvcmbSluzba.ValueMember = "Sifra";
        //        dgvcmbSluzba.DisplayMember = "Naziv";
        //        dgvcmbSluzba.DataSource = dtbl;
        //        dgvcmbSifSluUput.DataSource = dtbl.Copy();
        //    }
        //}

        // Za Fakturu
        private void TipUslugecmbFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Oznaka, Opis FROM TipUsluge", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Izaberi-";
                dtbl.Rows.InsertAt(topItem, 0);
                fakcmbTipUsluge.ValueMember = "Oznaka";
                fakcmbTipUsluge.DisplayMember = "Opis";
                fakcmbTipUsluge.DataSource = dtbl;
            }
        }

        private void FakSluzbaPrijemaCmbBoxFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Sifra, Naziv FROM SluzbaRZZO", sqlCon);
                DataTable dtblFak = new DataTable();
                sqlDa.Fill(dtblFak);
                DataRow topItem = dtblFak.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Izaberi-";
                dtblFak.Rows.InsertAt(topItem, 0);
                fakcmbSluzbaPri.ValueMember = "Sifra";
                fakcmbSluzbaPri.DisplayMember = "Naziv";
                fakcmbSluzbaOtp.ValueMember = "Sifra";
                fakcmbSluzbaOtp.DisplayMember = "Naziv";
                fakcmbSluzbaPri.DataSource = dtblFak;
                fakcmbSluzbaOtp.DataSource = dtblFak.Copy();
            }
        }

        private void FakDijagnozeCmbBoxFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Sifra, ID_Dijagnoza FROM Dijagnoza", sqlCon);
                DataTable dtblFak = new DataTable();
                sqlDa.Fill(dtblFak);
                DataRow topItem = dtblFak.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Izaberi-";
                dtblFak.Rows.InsertAt(topItem, 0);
                fakcmbUputnaDij.ValueMember = "Sifra";
                fakcmbUputnaDij.DisplayMember = "ID_Dijagnoza";
                fakcmbZavrsnaDij.ValueMember = "Sifra";
                fakcmbZavrsnaDij.DisplayMember = "ID_Dijagnoza";
                fakcmbUputnaDij.DataSource = dtblFak;
                fakcmbZavrsnaDij.DataSource = dtblFak.Copy();
            }
        }

        private void FakD2iD3CmbBoxFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Sifra, ID_Dijagnoza FROM Dijagnoza", sqlCon);
                DataTable dtblFakD = new DataTable();
                sqlDa.Fill(dtblFakD);
                DataRow topItem = dtblFakD.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Izaberi-";
                dtblFakD.Rows.InsertAt(topItem, 0);
                fakcmbDodatnaD1.ValueMember = "Sifra";
                fakcmbDodatnaD1.DisplayMember = "ID_Dijagnoza";
                fakcmbDodatnaD2.ValueMember = "Sifra";
                fakcmbDodatnaD2.DisplayMember = "ID_Dijagnoza";
                fakcmbDodatnaD1.DataSource = dtblFakD;
                fakcmbDodatnaD2.DataSource = dtblFakD.Copy();
            }
        }

        private void OOPCmbBoxFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Sifra, ID_OOP FROM OOP", sqlCon);
                DataTable dtblFak = new DataTable();
                sqlDa.Fill(dtblFak);
                DataRow topItem = dtblFak.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Izaberi-";
                dtblFak.Rows.InsertAt(topItem, 0);
                fakcmbOOP.ValueMember = "Sifra";
                fakcmbOOP.DisplayMember = "ID_OOP";
                fakcmbOOP.DataSource = dtblFak;
            }
        }

        private void FakOOcmbFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Oznaka, Naziv FROM OO", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Izaberi-";
                dtbl.Rows.InsertAt(topItem, 0);
                fakcmbOO.ValueMember = "Oznaka";
                fakcmbOO.DisplayMember = "Naziv";
                fakcmbOO.DataSource = dtbl;

            }
        }

        private void FakPOOcmbFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Oznaka, Naziv FROM POO", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Izaberi-";
                dtbl.Rows.InsertAt(topItem, 0);
                fakcmbPOO.ValueMember = "Oznaka";
                fakcmbPOO.DisplayMember = "Naziv";
                fakcmbPOO.DataSource = dtbl;

            }
        }


        // Za Uslugu na Fakturi

        private void UslugaCmbBoxFill()
        {

            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT SifraUsluga, Naziv, CenaA FROM UslugaRZZO", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Izaberi uslugu-";
                dtbl.Rows.InsertAt(topItem, 0);
                FakcmbUsluga.ValueMember = "SifraUsluga";
                FakcmbUsluga.DisplayMember = "Naziv";
                cmbBoxUsluga.DisplayMember = "SifraUsluga";
                FakcmbUsluga.DataSource = dtbl;
                cmbBoxUsluga.DataSource = dtbl;

                //foreach (DataRow dr in dtbl.Rows)
                //{
                //    FakcmbUsluga.Items.Add(dr["Naziv"].ToString());
                //}
                sqlCon.Close();
            }
        }


        private void LekCmbBoxFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Lek.SifraLeka, Lek.FabrickoIme, sLek.CenaLeka, sLek.DatumK FROM Lek INNER JOIN sLek ON Lek.ID_Lek = sLek.ID_Lek WHERE(sLek.DatumK IS NULL)", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Izaberi LEK-";
                dtbl.Rows.InsertAt(topItem, 0);
                FakcmbLek.ValueMember = "SifraLeka";
                FakcmbLek.DisplayMember = "FabrickoIme";
                cmbBoxLek.DisplayMember = "CenaLeka";
                cmbBoxSifraLeka.DisplayMember = "SifraLeka";
                FakcmbLek.DataSource = dtbl;
                cmbBoxLek.DataSource = dtbl;
                cmbBoxSifraLeka.DataSource = dtbl;

                sqlCon.Close();
            }
        }


        private void FakcmbUsluga_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connString))

            {
                sqlCon.Open();
                cmd = new SqlCommand("SELECT * FROM UslugaRZZO WHERE Naziv ='" + FakcmbUsluga.Text + "'", sqlCon);
                cmd.ExecuteNonQuery();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string cena = dr["cenaA"].ToString();
                    txtBoxCena.Text = cena;
                }
                sqlCon.Close();
            }

        }       


        private void SluzbaUslugaCmbBoxFill()
         {
                using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDaSlUsl = new SqlDataAdapter("SELECT Sifra, Naziv FROM SluzbaRZZO", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDaSlUsl.Fill(dtbl);
                    DataRow topItem = dtbl.NewRow();
                    topItem[0] = 0;
                    topItem[1] = "-Izaberi-";
                    dtbl.Rows.InsertAt(topItem, 0);
                    fakcmbSluzba.ValueMember = "Sifra";
                    fakcmbSluzba.DisplayMember = "Naziv";
                    fakcmbSluzbaUputa.ValueMember = "Sifra";
                    fakcmbSluzbaUputa.DisplayMember = "Naziv";
                    cmbBoxSluzba.DisplayMember = "Sifra";
                    cmbBoxUputilaSluzba.DisplayMember = "Sifra";
                    fakcmbSluzba.DataSource = dtbl;
                    cmbBoxSluzba.DataSource = dtbl;
                    fakcmbSluzbaUputa.DataSource = dtbl.Copy();
                    cmbBoxUputilaSluzba.DataSource = dtbl.Copy();
                }
         }

        private void UputilaSluzbaUslugaCmbBoxFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDaSlUsl = new SqlDataAdapter("SELECT Sifra, Naziv FROM SluzbaRZZO", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDaSlUsl.Fill(dtbl);
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Izaberi službu uputa...-";
                dtbl.Rows.InsertAt(topItem, 0);
                fakcmbSluzbaUputa.ValueMember = "Sifra";
                fakcmbSluzbaUputa.DisplayMember = "Naziv";
                cmbBoxUputilaSluzba.DisplayMember = "Sifra";
                fakcmbSluzbaUputa.DataSource = dtbl;
                cmbBoxUputilaSluzba.DataSource = dtbl;
            }
        }



        private void TabNovi_Click(object sender, EventArgs e)
        {

        }

        private void FrmOsnovna_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sekundarDataSet.OL' table. You can move, or remove it, as needed.
            {
                this.oLTableAdapter.Fill(this.sekundarDataSet.OL);
                cmbKolonaZaPretragu.SelectedIndex = 1;
                dataGridView1.Visible = false;
            }

            // Za osiguranika
            FilijalaCmbBoxFill();
            IspostavaCmbFill();
            OOcmbFill();
            POOcmbFill();
            DrzavacmbFill();                        
            //SluzbaCmbBoxFill();

            // Za fakturu
            TipUslugecmbFill();
            FakSluzbaPrijemaCmbBoxFill();
            FakDijagnozeCmbBoxFill();
            FakD2iD3CmbBoxFill();
            LekarCmbBoxFill();
            OOPCmbBoxFill();
            FakOOcmbFill();
            FakPOOcmbFill();
            //FakcmbUsluga_SelectedIndexChanged();

            //Za uslugu na fakturi
            SluzbaUslugaCmbBoxFill();
            UputilaSluzbaUslugaCmbBoxFill();
            UslugaCmbBoxFill();
            LekCmbBoxFill();

            //Add items to combo za vrstu lečenja
            fakcmbVrstaLec.Items.Clear();
            //Init data
            List<VrstaLecenja> listvrstaLecenja = new List<VrstaLecenja>
            {
                new VrstaLecenja() { ID = "1", Name = "Ambulantno" },
                new VrstaLecenja() { ID = "2", Name = "Stacionarno" },
                new VrstaLecenja() { ID = "3", Name = "Dnevna bolnica" }
            };

            fakcmbVrstaLec.DataSource = listvrstaLecenja;
            fakcmbVrstaLec.ValueMember = "ID";
            fakcmbVrstaLec.DisplayMember = "Name";

            //Add items to combo
            cmbPol.Items.Clear();
            //Init data
            List<Pol> list = new List<Pol>
            {
                new Pol() { ID = "M", Name = "Muški" },
                new Pol() { ID = "Z", Name = "Ženski" },
                new Pol() { ID = "N", Name = "Neodređen" }
            };
            //Set display member and value member
            cmbPol.DataSource = list;
            cmbPol.ValueMember = "ID";
            cmbPol.DisplayMember = "Name";
        }

        private void TabPretraga_Click(object sender, EventArgs e)
        {

        }

        private void TxtPodatakZaPretragu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtPodatakZaPretragu.Text))
                    oLBindingSource1.Filter = string.Empty;
                else
                    dataGridView1.Visible = true;
                    oLBindingSource1.Filter = string.Format("{0} = '{1}'", cmbKolonaZaPretragu.Text, txtPodatakZaPretragu.Text);
            }
        }


        private void FakbtnSnimiFakturu_Click(object sender, EventArgs e)
        {
            if (ValidateFaktura())
            {
                //int inSifra = 0;
                int _Sifra = 0;
                int _SifraStav = 0;
                using (SqlConnection Fakconn = new SqlConnection(Properties.Settings.Default.connString))
                {   
                        //Fakconn.Open();
                  //EFOsiguranik- MASTER
                        SqlCommand sqlCommand = new SqlCommand("Faktura", Fakconn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };

                        //sqlCommand.Parameters.AddWithValue("@Sifra", inSifra);

                        sqlCommand.Parameters.Add(new SqlParameter("@Sifra", SqlDbType.Int));
                        sqlCommand.Parameters["@Sifra"].Direction = ParameterDirection.Output;
                        //sqlCommand.Parameters.AddWithValue("@SifraELFak",);

                        sqlCommand.Parameters.Add(new SqlParameter("@Filijala", SqlDbType.Int));
                        sqlCommand.Parameters["@Filijala"].Value = fakcmbFilijala.Text;
                        sqlCommand.Parameters.AddWithValue("@Ispostava", fakcmbIspostava.SelectedValue);
                        sqlCommand.Parameters.AddWithValue("@Prezime", faktxtPrezime.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@Ime", faktxtIme.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@LBO", faktxtLBO.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@JMBG", faktxtJMBG.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@BZK", faktxtBrojZK.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@Nosilac", fakrdbNosilacDA.Checked ? "1" : "0");
                        sqlCommand.Parameters.AddWithValue("@VrstaLecenja", fakcmbVrstaLec.SelectedValue);
                        sqlCommand.Parameters.AddWithValue("@DatumOd", fakdtpDatumPoc.Value);
                        sqlCommand.Parameters.AddWithValue("@DatumDo", fakdtpDatumKraja.Value);
                        sqlCommand.Parameters.AddWithValue("@UpuDijag", fakcmbUputnaDij.SelectedValue);
                        sqlCommand.Parameters.AddWithValue("@ZavrDijag", fakcmbZavrsnaDij.SelectedValue);
                        sqlCommand.Parameters.AddWithValue("@OOParticipacija", fakcmbOOP.SelectedValue);
                        sqlCommand.Parameters.Add(new SqlParameter("@OO", SqlDbType.Int));
                        sqlCommand.Parameters["@OO"].Value = fakcmbOO.SelectedValue;
                        sqlCommand.Parameters.Add(new SqlParameter("@POO", SqlDbType.Int));
                        sqlCommand.Parameters["@POO"].Value = fakcmbPOO.SelectedValue;                        
                        sqlCommand.Parameters.Add(new SqlParameter("@Ucesce", SqlDbType.Decimal));
                        sqlCommand.Parameters["@Ucesce"].Value = faktxtUcesce.Text;
                        sqlCommand.Parameters.AddWithValue("@BrojKartona", faktxtBrojKartona.Text.Trim());
                        sqlCommand.Parameters.Add(new SqlParameter("@IznFak", SqlDbType.Decimal));
                        sqlCommand.Parameters["@IznFak"].Value = faktxtIznosFakture.Text;
                        sqlCommand.Parameters.Add(new SqlParameter("@ID_EFVrsta",SqlDbType.Int));
                        sqlCommand.Parameters["@ID_EFVrsta"].Value = faktxtID_EFVrsta.Text;
                        sqlCommand.Parameters.AddWithValue("@OLPoKonvenciji", fakrdbKonvencijaNE.Checked ? "0" : "1");                        
                        //sqlCommand.Parameters.AddWithValue("@Drzava", fakcmbDrzava.SelectedValue);
                        //sqlCommand.Parameters.AddWithValue("@VrstaIspraveKonvencija", faktxtVrstaIspKonv.Text.Trim());
                        //sqlCommand.Parameters.AddWithValue("@BrojIspraveKonvencija", faktxtBrojIspKonv.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@Napomena", faktxtNapomenaKonv.Text);
                        sqlCommand.Parameters.AddWithValue("@TipUsluge", fakcmbTipUsluge.SelectedValue);
                        sqlCommand.Parameters.Add(new SqlParameter("@SifraOL", SqlDbType.Int));
                        sqlCommand.Parameters["@SifraOL"].Value = faktxtSifraOL.Text;
                        
                        sqlCommand.Parameters.AddWithValue("@Dijag2", fakcmbDodatnaD1.SelectedValue);
                        sqlCommand.Parameters.AddWithValue("@Dijag3", fakcmbDodatnaD2.SelectedValue);
                        sqlCommand.Parameters.AddWithValue("@SifSluPri", fakcmbSluzbaPri.SelectedValue);
                        sqlCommand.Parameters.AddWithValue("@SifSluOtp", fakcmbSluzbaOtp.SelectedValue);

                        //_Sifra = Convert.ToInt32(sqlCommand.ExecuteScalar());
                        //inSifraEFOsiguranik = _Sifra;
                    Fakconn.Open();
                    _Sifra = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    //sqlCommand.ExecuteNonQuery();
                }                

                //Details - Stavke
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    connection.Open();
                    
                    foreach (DataGridViewRow dgvRow in fakdgvUsluge.Rows)
                    {  if (dgvRow.IsNewRow)
                        {
                            break;
                        }
                        else
                        {

                            SqlCommand sqlCommand = new SqlCommand("EFStavkeFakture", connection)
                            {
                                CommandType = CommandType.StoredProcedure
                            };

                            //sqlCommand.Parameters.AddWithValue("@SifraEFOsiguranik", Convert.ToInt32(dgvRow.Cells["dgvtxtSifraEFOsiguranik"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtSifraEFOsiguranik"].Value));                            
                            sqlCommand.Parameters.AddWithValue(parameterName: "@SifraEFOsiguranik",value: _Sifra);
                            sqlCommand.Parameters.Add(new SqlParameter("@Sifra", SqlDbType.Int));
                            sqlCommand.Parameters["@Sifra"].Direction = ParameterDirection.Output;
                            //sqlCommand.Parameters.AddWithValue("@Sifra", _Sifra);
                            sqlCommand.Parameters.AddWithValue("@ID_Usluga", value: intID_Usluga);
                            //sqlCommand.Parameters.AddWithValue("@ID_Usluga", Convert.ToInt32(dgvRow.Cells["ID_Usluga"].Value == DBNull.Value ? "0" : dgvRow.Cells["ID_Usluga"].Value));
                            sqlCommand.Parameters.AddWithValue("@SifraUsluga", Convert.ToString(dgvRow.Cells["dgvcmbSifra"].Value == DBNull.Value ? "" : dgvRow.Cells["dgvcmbSifra"].Value));
                            sqlCommand.Parameters.AddWithValue("@Cena", Convert.ToDecimal(dgvRow.Cells["dgvtxtCena"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtCena"].Value));
                            //sqlCommand.Parameters.AddWithValue("@Cena", value: cenaUsluge);
                            //sqlCommand.Parameters.AddWithValue("@Cena", dgvRow.Cells["dgvtxtCena"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtCena"].Value);
                            sqlCommand.Parameters.AddWithValue("@Kolicina", Convert.ToInt32(dgvRow.Cells["dgvtxtKolicina"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtKolicina"].Value));
                            sqlCommand.Parameters.AddWithValue("@UkupnaCena", Convert.ToDecimal(dgvRow.Cells["dgvtxtUkupnaCena"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtUkupnaCena"].Value));
                            //sqlCommand.Parameters.AddWithValue(parameterName: "@Datum", value: dgvRow.Cells["dgvtxtDatum"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtDatum"].Value);
                            sqlCommand.Parameters.Add(new SqlParameter("@Datum", SqlDbType.Date));
                            sqlCommand.Parameters["@Datum"].Value = Convert.ToDateTime(dgvRow.Cells["dgvtxtDatum"].Value);
                            sqlCommand.Parameters.AddWithValue("@ID_Lekar", dgvRow.Cells["dgvcmbID_Lekar"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvcmbID_Lekar"].Value);
                            sqlCommand.Parameters.AddWithValue("@Sluzba", dgvRow.Cells["dgvcmbSluzba"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvcmbSluzba"].Value);
                            sqlCommand.Parameters.AddWithValue("@SluzbaUput", dgvRow.Cells["dgvcmbSifSluUput"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvcmbSifSluUput"].Value);
                            //sqlCommand.Parameters.AddWithValue("@EksterniIDUsluge", dgvRow.Cells["@dgvtxtEksterniIDUsluge"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtEksterniIDUsluge"].Value);
                            //sqlCommand.Parameters.AddWithValue("@Napomena", dgvRow.Cells["dgvtxtNapomena"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtNapomena"].Value);
                            sqlCommand.Parameters.AddWithValue("@SifraELFak", dgvRow.Cells["dgvtxtSifraELFak"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtSifraELFak"].Value);
                            sqlCommand.Parameters.AddWithValue("@Ucesce", Convert.ToDecimal(dgvRow.Cells["dgvtxtUcesce"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtUcesce"].Value));
                            sqlCommand.Parameters.AddWithValue("@VrstaLecenja", dgvRow.Cells["dgvcmbVrstaLecenja"].Value == DBNull.Value ? "0" : dgvRow.Cells[columnName: "dgvcmbVrstaLecenja"].Value);

                            //sqlCommand.ExecuteNonQuery();
                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                            }
                            _SifraStav = Convert.ToInt32(sqlCommand.ExecuteScalar());

                            connection.Close();
                        }
                    }
                }

                //Odavde lekovi , ako radi
                using (SqlConnection connectionLek = new SqlConnection(Properties.Settings.Default.connString))
                {
                    if (connectionLek.State == ConnectionState.Closed)
                    {
                        connectionLek.Open();
                    }

                    foreach (DataGridViewRow dgvRowLek in fakdgvLek.Rows)
                    {
                        if (dgvRowLek.IsNewRow)
                        {
                            break;
                        }
                        else
                        {
                            SqlCommand sqlCommandLek = new SqlCommand("EFSanMatLekovi", connectionLek)
                            {
                                CommandType = CommandType.StoredProcedure
                            };
                            sqlCommandLek.Parameters.AddWithValue(parameterName: "@SifraEFStavka", value: _SifraStav);
                            sqlCommandLek.Parameters.Add(new SqlParameter("@Sifra", SqlDbType.Int));
                            sqlCommandLek.Parameters["@Sifra"].Direction = ParameterDirection.Output;
                            sqlCommandLek.Parameters.AddWithValue("@ID_SanMat", value: intID_SanMat);
                            sqlCommandLek.Parameters.AddWithValue("@SifraSanMat", Convert.ToString(dgvRowLek.Cells["dgvSifraLeka"].Value == DBNull.Value ? "" : dgvRowLek.Cells["dgvSifraLeka"].Value));
                            sqlCommandLek.Parameters.AddWithValue("@Kolicina", Convert.ToDecimal(dgvRowLek.Cells["dgvKolicinaLeka"].Value == DBNull.Value ? "0" : dgvRowLek.Cells["dgvKolicinaLeka"].Value));
                            sqlCommandLek.Parameters.AddWithValue("@Cena", Convert.ToDecimal(dgvRowLek.Cells["dgvCenaLeka"].Value == DBNull.Value ? "0" : dgvRowLek.Cells["dgvCenaLeka"].Value));
                            sqlCommandLek.Parameters.AddWithValue("@Vrsta_Mat", dgvRowLek.Cells["dgvVrsta_Mat"].Value == DBNull.Value ? "0" : dgvRowLek.Cells[columnName: "dgvVrsta_Mat"].Value);

                            sqlCommandLek.ExecuteNonQuery();
                        }
                    }
                    connectionLek.Close();
                    MessageBox.Show("Uspešno snimljena faktura...");
                }

                FillEFStavkeDataGrid();
            }

            bool ValidateFaktura()
            {
                bool _isValid = true;
                if (faktxtPrezime.Text.Trim() == "")
                {
                    MessageBox.Show("Molim unesite prezime osiguranika...");
                    _isValid = false;
                }

                // Ovde ostale validacije
                if (faktxtIme.Text.Trim() == "")
                {
                    MessageBox.Show("Molim unesite ime osiguranika...");
                    _isValid = false;
                }
                return _isValid;
            }

          

        }

        private static SqlCommand GetSqlCommand(SqlCommand sqlCommand)
        {
            return sqlCommand;
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                DataGridViewRow _dgvCurrentRow = dataGridView1.CurrentRow;
               int inSifra = Convert.ToInt32(_dgvCurrentRow.Cells[0].Value);
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    connection.Open();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("OsiguraniciPoSifri", connection);
                    sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Sifra", inSifra);
                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    //Master - Fill
                    DataRow dataRow = dataSet.Tables[0].Rows[0];
                    faktxtBrojZK.Text = dataRow["BrojZK"].ToString();
                    faktxtLBO.Text = dataRow["LBO"].ToString();
                    faktxtJMBG.Text = dataRow["JMBG"].ToString();
                    faktxtPrezime.Text = dataRow["Prezime"].ToString();
                    faktxtIme.Text = dataRow["Ime"].ToString();                    
                    fakcmbOO.Text = dataRow["Sifra_OO"].ToString();
                    fakcmbPOO.Text = dataRow["Sifra_POO"].ToString();
                    faktxtSifraOL.Text = dataRow["Sifra"].ToString();
                    faktxtBrojKartona.Text = dataRow["Broj_kartona"].ToString();
                    ////Ovde Nosilac
                    //if (dataRow["Nosilac"].ToString() == "1")
                    //{
                    //    fakrdbNosilacDA.Checked = true;
                    //}
                    //else
                    //{
                    //    fakrdbNosilacNE.Checked = true;
                    //}

                    fakcmbOOP.Text = dataRow["OO_participacije"].ToString();
                    fakcmbFilijala.Text = dataRow["Sifra_Filijala"].ToString();
                    fakcmbIspostava.Text = dataRow["Sifra_Ispostava"].ToString();

                    tabControl1.SelectedIndex = 2;
                }

            }
        }

        private void FillEFStavkeDataGrid()
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("EFStavkeViewAll", sqlCon);
                sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlData.SelectCommand.Parameters.AddWithValue("@Sifra", inSifraEFOsiguranik);
                DataTable dataTable = new DataTable();
                sqlData.Fill(dataTable);
                fakdgvUsluge.DataSource = dataTable;
                //sqlData.SelectCommand.BeginExecuteNonQuery(parameterName: "@Sifra", value: _Sifra);
                //Ovde vidi da li treba još formatiranja dgv-a

            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearNovogOL();
        }

        private void BtnNoviOLFaktura_Click(object sender, EventArgs e)
        {
            faktxtBrojZK.Text = txtBrojZK.Text.ToString();
            faktxtLBO.Text = txtLBO.Text;
            faktxtJMBG.Text = txtJMBG.Text;
            faktxtPrezime.Text = txtPrezime.Text;
            faktxtIme.Text = txtIme.Text;
            fakcmbOO.Text = cmbOO.Text;
            fakcmbPOO.Text = cmbPOO.Text;
            //faktxtSifraOL.Text = dataRow["Sifra"].ToString();
            ////Ovde Nosilac
            ////if (dataRow["Je_Nosilac"].ToString() == "1")
            ////{
            ////    fakrdbNosilacDA.Checked = true;
            ////}
            ////else
            ////{
            ////    fakrdbNosilacNE.Checked = true;
            ////}

            //fakcmbOOP.Text = dataRow["OO_participacije"].ToString();
            fakcmbFilijala.Text = cmbFilijala.Text;
            fakcmbIspostava.Text = cmbIspostava.Text;

            tabControl1.SelectedIndex = 2;
        }

        private void FakcmbUsluga_DisplayMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnDodajUslugu_Click(object sender, EventArgs e)
        {
            int _row = 0;
            fakdgvUsluge.Rows.Add();
            _row = fakdgvUsluge.Rows.Count - 2;
            fakdgvUsluge["dgvcmbSifra", _row].Value = cmbBoxUsluga.Text;
            fakdgvUsluge["dgvtxtKolicina", _row].Value = txtBoxKolicina.Text;
            fakdgvUsluge["dgvtxtCena", _row].Value = txtBoxCena.Text;
            fakdgvUsluge["dgvtxtUkupnaCena", _row].Value = textBoxIznos.Text;
            fakdgvUsluge["dgvtxtDatum", _row].Value = dateTimePickerUsluge.Text;
            fakdgvUsluge["dgvcmbID_Lekar", _row].Value = cmbBoxIDLekar.Text;
            fakdgvUsluge["dgvcmbSluzba", _row].Value = cmbBoxSluzba.Text;
            fakdgvUsluge["dgvcmbSifSluUput", _row].Value = cmbBoxUputilaSluzba.Text;
            fakdgvUsluge["dgvtxtUcesce", _row].Value = txtBoxUcesce.Text;

            //Ukupno Izmos
            Double sumaIznosa = 0;
            for (int i = 0; i < fakdgvUsluge.RowCount; i++)
            {
                sumaIznosa += Convert.ToDouble(fakdgvUsluge.Rows[i].Cells[4].Value);
            }
            textBoxSumaIznosa.Text = sumaIznosa.ToString();
        }

        private void BtnDodajLek_Click(object sender, EventArgs e)
        {
            int _row = 0;
            fakdgvLek.Rows.Add();
            _row = fakdgvLek.Rows.Count - 2;
            fakdgvLek["dgvSifraLeka", _row].Value = cmbBoxSifraLeka.Text;
            fakdgvLek["dgvCenaLeka", _row].Value = cmbBoxLek.Text;
            fakdgvLek["dgvKolicinaLeka", _row].Value = txtBoxKolicinaLeka.Text;
            fakdgvLek["dgvVrsta_Mat", _row].Value = txtBoxVrstaLeka.Text;
        }

        private void TxtBoxCena_TextChanged(object sender, EventArgs e)
        {

            if (!Double.TryParse(txtBoxCena.Text, out double cena) || !Double.TryParse(txtBoxKolicina.Text, out double kolicina))
                return;
            Double iznos = cena * kolicina;

            textBoxIznos.Text = iznos.ToString();
        }

        private void TxtBoxKolicina_TextChanged(object sender, EventArgs e)
        {

            if (!Double.TryParse(txtBoxCena.Text, out double cena) || !Double.TryParse(txtBoxKolicina.Text, out double kolicina))
                return;
            Double iznos = cena * kolicina;

            textBoxIznos.Text = iznos.ToString();
        }


    }
    internal class Pol
    {
        public Pol()
        {
        }

        public string ID { get; set; }
        public string Name { get; set; }
    }

    internal class VrstaLecenja
    {
        public VrstaLecenja()
        {
        }

        public string ID { get; set; }
        public string Name { get; set; }
    }



    

}






