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

namespace SekundarNovi
{
    public partial class frmOsnovna : Form
    {
        public frmOsnovna()
        {
            InitializeComponent();
        }

        private void btnSnimiOsiguranika_Click(object sender, EventArgs e)
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
            if (txtPrezime.Text.Trim()=="")
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

        private void tabNovi_Click(object sender, EventArgs e)
        {

        }

        private void frmOsnovna_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sekundarDataSet.OL' table. You can move, or remove it, as needed.
            {
                this.oLTableAdapter.Fill(this.sekundarDataSet.OL);
                cmbKolonaZaPretragu.SelectedIndex = 1;
            }

            FilijalaCmbBoxFill();
            IspostavaCmbFill();
            OOcmbFill();
            POOcmbFill();
            DrzavacmbFill();

            //Add items to combo
            cmbPol.Items.Clear();
            //Init data
            List<Pol> list = new List<Pol>();
            list.Add(new Pol() { ID = "M", Name = "Muški" });
            list.Add(new Pol() { ID = "Z", Name = "Ženski" });
            list.Add(new Pol() { ID = "N", Name = "Neodređen" });
            //Set display member and value member
            cmbPol.DataSource = list;
            cmbPol.ValueMember = "ID";
            cmbPol.DisplayMember = "Name";
        }

        private void tabPretraga_Click(object sender, EventArgs e)
        {

        }

        private void txtPodatakZaPretragu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtPodatakZaPretragu.Text))
                    oLBindingSource1.Filter = string.Empty;
                else
                    oLBindingSource1.Filter = string.Format("{0} = '{1}'", cmbKolonaZaPretragu.Text, txtPodatakZaPretragu.Text);
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
}
