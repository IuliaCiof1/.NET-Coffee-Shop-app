using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS
{
    public partial class Angajati : Form
    {
        public Angajati()
        {
            InitializeComponent();
        }

        private void Angajati_Load(object sender, EventArgs e)
        {
            DataSet ds = SQLConnect.ConnectDB("select Nume, CNP, Serie, Functie, [Ore Norma], Perioada, [Salar de baza], [Numar Mese] from Angajati;");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.ClearSelection();
        }

        //private void btnStatPlata_Click(object sender, EventArgs e)
        //{
        //    //StatPlata sp = new StatPlata();
        //    //sp.ShowDialog();
        //}

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            OreSuplimentare os = new OreSuplimentare();
            os.ShowDialog();
        }

        private void siticoneTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = null;
            switch (siticoneTabControl1.SelectedTab.Text)
            {
                case "Angajati":
                    ds = SQLConnect.ConnectDB("select Nume, CNP, Serie, Functie, [Ore Norma], Perioada, [Salar de baza], [Numar Mese] from Angajati;");
                    dataGridView1.DataSource = ds.Tables[0];

                    dataGridView1.ClearSelection();

                    break;

                case "Stat de plata":    
                    ds = SQLConnect.ConnectDB("select Nume from Angajati;");

                    //Populare combobox
                    comboBoxNume.Items.Clear();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                        comboBoxNume.Items.Add(dr["Nume"].ToString());

                    ds = SQLConnect.ConnectDB("select * from Stat_de_Plata;");
                    dataGridView2.DataSource = ds.Tables[0];

                    dataGridView2.ClearSelection();
                    break;

                case "Ore suplimentare":
                    ds = SQLConnect.ConnectDB("select Nume from Angajati;");

                    //Populare combobox
                    comboBoxAngajati.Items.Clear();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                        comboBoxAngajati.Items.Add(dr["Nume"].ToString());

                    ds = SQLConnect.ConnectDB("select Nume, [Ore Suplimentare], [Plata Ora Suplimentara], [Ore Suplimentare]*[Plata Ora Suplimentara] as [Plata Suplimentara] from Angajati where [Ore Suplimentare] is not null;");
                    dataGridView3.DataSource = ds.Tables[0];

                    dataGridView3.ClearSelection();
                    break;
            }
        }

        private void btnAdaugaAngajat_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            try
            {
                if (comboBoxFunctie.SelectedItem.ToString() == "Ospatar")
                {
                    ds = SQLConnect.ConnectDB($"insert into Angajati (Nume, CNP, Serie, Functie, [Ore Norma], Perioada, [Salar de baza], [Numar Mese]) " +
                        $"values ('{txtBoxNume.Text}','{txtBoxCNP.Text}','{txtBoxSerie.Text}','{comboBoxFunctie.SelectedItem.ToString()}',{txtBoxOraNorma.Text}," +
                        $"'{comboBoxPerioada.SelectedItem.ToString()}', {txtBoxSalar.Text}, {txtBoxMese.Text});" +
                        "select Nume, CNP, Serie, Functie, [Ore Norma], Perioada, [Salar de baza], [Numar Mese] from Angajati;");
                }
                else
                {

                    ds = SQLConnect.ConnectDB($"insert into Angajati (Nume, CNP, Serie, Functie, [Ore Norma], Perioada, [Salar de baza]) " +
                        $"values ('{txtBoxNume.Text}','{txtBoxCNP.Text}','{txtBoxSerie.Text}','{comboBoxFunctie.SelectedItem.ToString()}',{txtBoxOraNorma.Text}," +
                        $"'{comboBoxPerioada.SelectedItem.ToString()}', {txtBoxSalar.Text});" +
                        "select Nume, CNP, Serie, Functie, [Ore Norma], Perioada, [Salar de baza], [Numar Mese] from Angajati;");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return;
            }

            dataGridView1.DataSource = ds.Tables[0];

            //Resetare TextBox-uri si ComboBox-uri
            foreach (Control c in siticonePanel1.Controls.OfType<Control>())
            {
                if (c is TextBox)
                    ((TextBox)c).Text = "";
                else if (c is ComboBox)
                    ((ComboBox)c).SelectedItem = -1;
            }

        }

        private void btnStergeAngajat_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = SQLConnect.ConnectDB($"delete from Angajati where Nume='" + dataGridView1.SelectedCells[0].Value.ToString() + "';" +
                "select Nume, CNP, Serie, Functie, [Ore Norma], Perioada, [Salar de baza], [Numar Mese] from Angajati;");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return;
            }
        }

        private void btnAdaugaStPlata_Click(object sender, EventArgs e)
        {
            DataSet ds = null;

            try
            {
                ds = SQLConnect.ConnectDB($"insert into Stat_de_Plata (Nume, [Salar de baza], [Venit brut], [Venit net], " +
                            $"[Deducere personala de baza], [Impozit calculat si retinut], [Salariul net], Avans, [Alte retineri])" +
                            $"values ('{comboBoxNume.SelectedItem.ToString()}', {txtBoxSalarBaza.Text}, {txtBoxVenitBrut.Text}, " +
                            $"{txtBoxVenitNet.Text}, {txtBoxDeducere.Text}, {txtBoxImpozit.Text}, " +
                            $"{txtBoxSalariuNet.Text}, {txtBoxAvans.Text}, {txtBoxRetineri.Text});" +
                            $"update Stat_de_Plata set [Total de plata] = (select " +
                            $"[Salar de baza] +[Venit brut] +[Venit net] +[Deducere personala de baza] +[Impozit calculat si retinut]" +
                            $"+[Salariul net]+Avans+[Alte retineri] from Stat_de_Plata where Nume = '{comboBoxNume.SelectedItem.ToString()}') where Nume = '{comboBoxNume.SelectedItem.ToString()}';" +
                            $"select * from Stat_de_Plata;");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return;
            }

            dataGridView2.DataSource = ds.Tables[0];

            //Resetare TextBox-uri si ComboBox-uri
            foreach (TextBox tb in siticonePanel2.Controls.OfType<TextBox>())
                tb.Text = "";
            comboBoxNume.SelectedItem = null;
        }

        private void btnStergeStPlata_Click(object sender, EventArgs e)
        {
            DataSet ds = SQLConnect.ConnectDB("delete from Stat_de_Plata where Nume='" + dataGridView2.SelectedCells[0].Value.ToString() + "';");

            ds = SQLConnect.ConnectDB("select * from Stat_de_Plata;");
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void btnAdaugaOraSupl_Click(object sender, EventArgs e)
        {
            DataSet ds = SQLConnect.ConnectDB($"update Angajati set [Ore Suplimentare]={txtBoxOreSuplim.Text}, [Plata Ora Suplimentara]={txtBoxPlataOra.Text} where Nume='{comboBoxAngajati.SelectedItem.ToString()}';" +
                $"select Nume, [Ore Suplimentare], [Plata Ora Suplimentara], [Ore Suplimentare] *[Plata Ora Suplimentara] as [Plata Suplimentara] from Angajati where [Ore Suplimentare] is not null; ");

            dataGridView3.DataSource = ds.Tables[0];

            foreach (TextBox tb in siticonePanel3.Controls.OfType<TextBox>())
                tb.Text = "";
            comboBoxAngajati.SelectedItem = null;
        }

        private void btnStergeOraSupl_Click(object sender, EventArgs e)
        {
            DataSet ds;
            try
            {
                ds = SQLConnect.ConnectDB($"update Angajati set [Ore Suplimentare]=NULL, [Plata Ora Suplimentara]=NULL where Nume='{dataGridView3.SelectedCells[0].Value.ToString()}';" +
                    $"select Nume, [Ore Suplimentare], [Plata Ora Suplimentara], [Ore Suplimentare]*[Plata Ora Suplimentara] as [Plata Suplimentara] from Angajati where [Ore Suplimentare] is not null;");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return;
            }

            dataGridView3.DataSource = ds.Tables[0];
        }

        private void comboBoxFunctie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFunctie.SelectedItem.ToString() == "Ospatar")
            {
                lblMese.Visible = true;
                txtBoxMese.Visible = true;
            }
            else
            {
                lblMese.Visible = false;
                txtBoxMese.Visible = false;
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                btnStergeAngajat.Enabled = true;
                btnStergeAngajat.BackColor = Color.RosyBrown;

            }

            else
            {
                btnStergeAngajat.Enabled = false;
                btnStergeAngajat.BackColor = Color.FromArgb(128, 64, 64);
            }
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                btnStergeStPlata.Enabled = true;
                btnStergeStPlata.BackColor = Color.RosyBrown;

            }

            else
            {
                btnStergeStPlata.Enabled = false;
                btnStergeStPlata.BackColor = Color.FromArgb(128, 64, 64);
            }
        }

        private void dataGridView3_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 1)
            {
                btnStergeOraSupl.Enabled = true;
                btnStergeOraSupl.BackColor = Color.RosyBrown;

            }

            else
            {
                btnStergeOraSupl.Enabled = false;
                btnStergeOraSupl.BackColor = Color.FromArgb(128, 64, 64);
            }
        }
    }
}
