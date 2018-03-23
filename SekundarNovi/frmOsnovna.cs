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
        int intID_Usluga = 0;
        private decimal decCenaAUsluge;

        public FrmOsnovna()
        {
            InitializeComponent();
        }

        private void BtnSnimiOsiguranika_Click(object sender, EventArgs e)
        {
            if (ValidateUnosNovogOL())
            {
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
                        sqlCommand.Parameters.Add(new SqlParameter("@LBO", SqlDbType.Int));
                        sqlCommand.Parameters["@LBO"].Value = txtLBO.Text.Trim();
                        sqlCommand.Parameters.Add(new SqlParameter("@JMBG", SqlDbType.VarChar, 15));
                        sqlCommand.Parameters["@JMBG"].Value = txtJMBG.Text.Trim();
                        sqlCommand.Parameters.Add(new SqlParameter("@BrojZK", SqlDbType.VarChar, 11));
                        sqlCommand.Parameters["@BrojZK"].Value = txtBrojZK.Text.Trim();
                        //sqlCommand.Parameters.Add(new SqlParameter("@Broj_kartona", SqlDbType.VarChar, 50));
                        //sqlCommand.Parameters["@Broj_kartona"].Value = txtKarton.Text;
                        sqlCommand.Parameters.Add(new SqlParameter("@Pol", SqlDbType.VarChar, 1));
                        sqlCommand.Parameters["@Pol"].Value = cmbPol.SelectedValue;
                        sqlCommand.Parameters.Add(new SqlParameter("@Datum_Rodjenja", SqlDbType.DateTime, 8));
                        sqlCommand.Parameters["@Datum_Rodjenja"].Value = dtpDatumRodjenja.Value;
                        sqlCommand.Parameters.AddWithValue("@Je_nosilac", rbtDa.Checked ? 1 : 0);
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
                        //sqlCommand.Parameters.Add(new SqlParameter("@OO_participacije", SqlDbType.Int));
                        //sqlCommand.Parameters["@OO_participacije"].Value = cmbOOP.SelectedValue;
                        sqlCommand.Parameters.Add(new SqlParameter("@Sifra_drzava", SqlDbType.VarChar, 3));
                        sqlCommand.Parameters["@Sifra_drzava"].Value = cmbDrzava.SelectedValue;

                        try
                        {
                            connection.Open();

                            sqlCommand.ExecuteNonQuery();
                        }
                        finally
                        {

                            connection.Close();
                            MessageBox.Show("Uspešno sačuvano...");
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

        void LekarCmbBoxFill()
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
                fakcmbLekar.DataSource = dtblLekar;

            }
        }

        void SluzbaCmbBoxFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Sifra, Naziv FROM SluzbaRZZO", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Izaberi-";
                dtbl.Rows.InsertAt(topItem, 0);
                dgvcmbSluzba.ValueMember = "Sifra";
                dgvcmbSluzba.DisplayMember = "Naziv";
                dgvcmbSluzba.DataSource = dtbl;
                dgvcmbSifSluUput.DataSource = dtbl.Copy();
            }
        }

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
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT ID_UslugaRZZO, SifraUsluga, Naziv, CenaA FROM UslugaRZZO", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Izaberi-";
                dtbl.Rows.InsertAt(topItem, 0);
                dgvcmbSifra.ValueMember = "SifraUsluga";
                dgvcmbSifra.DisplayMember = "Naziv";
                dgvcmbSifra.DataSource = dtbl;
                //decCenaAUsluge = CenaA.Get;                
                //this.decCenaAUsluge =sqlDa.ToString("CenaA").Value;
            }
        }

        private void DgvcmbSifraChanged()    //CenatxtFill()
        {
            decimal decCenaAUsluge;

            using (SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.connString))
            {                
                SqlCommand command = new SqlCommand("Select CenaA FROM UslugaRzzo WHERE SifraUsluga = @SifraUsluga", sqlCon);
                command.Parameters.AddWithValue("@SifraUsluga", 1);
                try
                {
                    sqlCon.Open();
                    decCenaAUsluge = (decimal)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                    
                }
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
                fakcmbSluzba.DataSource = dtbl;
                
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
            }

            // Za osiguranika
            FilijalaCmbBoxFill();
            IspostavaCmbFill();
            OOcmbFill();
            POOcmbFill();
            DrzavacmbFill();
            UslugaCmbBoxFill();            
            SluzbaCmbBoxFill();

            // Za fakturu
            TipUslugecmbFill();
            FakSluzbaPrijemaCmbBoxFill();
            FakDijagnozeCmbBoxFill();
            FakD2iD3CmbBoxFill();
            LekarCmbBoxFill();
            OOPCmbBoxFill();
            FakOOcmbFill();
            FakPOOcmbFill();

            //Za uslugu na fakturi
            SluzbaUslugaCmbBoxFill();
            LekarCmbBoxFill();
            DgvcmbSifraChanged();


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
                    oLBindingSource1.Filter = string.Format("{0} = '{1}'", cmbKolonaZaPretragu.Text, txtPodatakZaPretragu.Text);
            }
        }

        private void FakbtnSnimiFakturu_Click(object sender, EventArgs e)
        {
            if (ValidateFaktura())
            {
                //int _Sifra = 0;                
                using (SqlConnection Fakconn = new SqlConnection(Properties.Settings.Default.connString))
                {
                    try
                    {
                        //Fakconn.Open();
                        //EFOsiguranik
                        SqlCommand sqlCommand = new SqlCommand("Faktura", Fakconn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };

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

                        Fakconn.Open();
                        sqlCommand.ExecuteNonQuery();

                    }
                    finally
                    {
                        Fakconn.Close();
                        MessageBox.Show("Osiguranik uspešno pripremljen za fakturu");
                    }
                    
                } 
               

                //Details
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    connection.Open();
                    MessageBox.Show("Stigao sam do dgv...");
                    foreach (DataGridViewRow dgvRow in fakdgvUsluge.Rows)
                    {

                        SqlCommand sqlCommand = new SqlCommand("EFStavkeFakture", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };

                        sqlCommand.Parameters.AddWithValue("@SifraEFOsiguranik", Convert.ToInt32(dgvRow.Cells["dgvtxtSifraEFOsiguranik"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtSifraEFOsiguranik"].Value));
                        sqlCommand.Parameters.Add(new SqlParameter("@Sifra", SqlDbType.Int));
                        sqlCommand.Parameters["@Sifra"].Direction = ParameterDirection.Output;
                        //sqlCommand.Parameters.AddWithValue("@Sifra", _Sifra);
                        sqlCommand.Parameters.AddWithValue("@ID_Usluga", value: intID_Usluga);
                        //sqlCommand.Parameters.AddWithValue("@ID_Usluga", Convert.ToInt32(dgvRow.Cells["ID_Usluga"].Value == DBNull.Value ? "0" : dgvRow.Cells["ID_Usluga"].Value));
                        sqlCommand.Parameters.AddWithValue("@SifraUsluga", dgvRow.Cells["dgvcmbSifra"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvcmbSifra"].Value);
                        sqlCommand.Parameters.AddWithValue("@Cena", value: decCenaAUsluge);
                        //sqlCommand.Parameters.AddWithValue("@Cena", dgvRow.Cells["dgvtxtCena"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtCena"].Value);
                        sqlCommand.Parameters.AddWithValue("@Kolicina", Convert.ToInt32(dgvRow.Cells["dgvtxtKolicina"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtKolicina"].Value));
                        sqlCommand.Parameters.AddWithValue("@UkupnaCena", dgvRow.Cells["dgvtxtUkupnaCena"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtUkupnaCena"].Value);
                        //sqlCommand.Parameters.AddWithValue(parameterName: "@Datum", value: dgvRow.Cells["dgvtxtDatum"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtDatum"].Value);
                        sqlCommand.Parameters.Add(new SqlParameter("@Datum", SqlDbType.Date));
                        sqlCommand.Parameters["@Datum"].Value = Convert.ToDateTime(dgvRow.Cells["dgvtxtDatum"].Value);
                        sqlCommand.Parameters.AddWithValue("@ID_Lekar", dgvRow.Cells["dgvcmbID_Lekar"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvcmbID_Lekar"].Value);
                        sqlCommand.Parameters.AddWithValue("@Sluzba", dgvRow.Cells["dgvcmbSluzba"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvcmbSluzba"].Value);
                        sqlCommand.Parameters.AddWithValue("@SluzbaUput", dgvRow.Cells["dgvcmbSifSluUput"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvcmbSifSluUput"].Value);
                        //sqlCommand.Parameters.AddWithValue("@EksterniIDUsluge", dgvRow.Cells["@dgvtxtEksterniIDUsluge"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtEksterniIDUsluge"].Value);
                        sqlCommand.Parameters.AddWithValue("@Napomena", dgvRow.Cells["dgvtxtNapomena"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtNapomena"].Value);
                        sqlCommand.Parameters.AddWithValue("@SifraELFak", dgvRow.Cells["dgvtxtSifraELFak"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtSifraELFak"].Value);
                        sqlCommand.Parameters.AddWithValue("@Ucesce", dgvRow.Cells["dgvtxtUcesce"].Value == DBNull.Value ? "0" : dgvRow.Cells["dgvtxtUcesce"].Value);
                        sqlCommand.Parameters.AddWithValue("@VrstaLecenja", dgvRow.Cells["dgvcmbVrstaLecenja"].Value == DBNull.Value ? "0" : dgvRow.Cells[columnName: "dgvcmbVrstaLecenja"].Value);

                        GetSqlCommand(sqlCommand).ExecuteNonQuery();

                    }
                }
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
                    //Ovde Nosilac
                    //if (dataRow["Je_Nosilac"].ToString() == "1")
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
