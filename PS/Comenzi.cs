using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace PS
{
    public partial class Comenzi : Form
    {
        public Comenzi()
        {
            InitializeComponent();
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Abonare la control_ControlChanged event handler
            txtBoxMasa.TextChanged += new EventHandler(control_ControlChanged);
            comboBoxOspatar.TextChanged += new EventHandler(control_ControlChanged);
            comboBoxProdus.TextChanged += new EventHandler(control_ControlChanged);
            refresh();

            DataSet ds = SQLConnect.ConnectDB("select Produs from Meniu_Produse order by Categorie");

            //Populare ComboBox pentru Produse
            comboBoxProdus.Items.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                comboBoxProdus.Items.Add(dr[0].ToString());
            }

            dataGridView1.ClearSelection();
        }

        private void control_ControlChanged(object sender, EventArgs e)
        {
            if (txtBoxMasa.Text != "" && comboBoxProdus.SelectedItem!=null && comboBoxOspatar.SelectedItem!=null)
            {
                btnAdaugaComanda.Enabled = true;
                btnAdaugaComanda.BackColor = Color.RosyBrown;
            }
            else
            {
                btnAdaugaComanda.Enabled = false;
                btnAdaugaComanda.BackColor = Color.FromArgb(128, 64, 64);
            }
        }

        private void btnNotaComanda_Click(object sender, EventArgs e)
        {
            NoteComanda nc = new NoteComanda();
            nc.ShowDialog();
        }

        private void btnNotaPlata_Click(object sender, EventArgs e)
        {
            NotePlata np = new NotePlata();
            np.ShowDialog();
        }

        private void refresh()
        {
            comboBoxOspatar.Items.Clear();
            DataSet ds = SQLConnect.ConnectDB("select [Numar Comanda], [Numar Masa], Ospatar, [Nota Comanda] from  Mese");
            dataGridView1.DataSource = ds.Tables[0];

            //Adauga in ComboBox doar Ospatari care inca nu au comenzi cat numarul de mese din Angajati
            ds = SQLConnect.ConnectDB("select Nume from Angajati where Functie='Ospatar'");
            DataSet ds1;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ds1 = SQLConnect.ConnectDB($"exec DisponibilitateOspatar '{dr[0].ToString()}'");

                if (ds1.Tables.Count > 1 && (ds1.Tables[1].Rows.Count > 0 && ds1.Tables[1].Rows[0][0].ToString() == dr[0].ToString()))
                {
                    comboBoxOspatar.Items.Add(dr[0].ToString());

                }
            }

            dataGridView1.ClearSelection();
            
            //Resetare TextBox-uri si ComboBox-uri
            txtBoxMasa.Clear();
            comboBoxOspatar.SelectedIndex = -1;
            comboBoxProdus.SelectedIndex = -1;
        }

        private void btnAdaugaComanda_Click(object sender, EventArgs e)
        {
            DataSet ds = ds = SQLConnect.ConnectDB($"insert into Mese ([Numar Masa], [Nota Comanda], [Ospatar]) " +
                    $"values ({txtBoxMasa.Text}, '{comboBoxProdus.SelectedItem.ToString()}', '{comboBoxOspatar.SelectedItem.ToString()}')");
            
            
            refresh();
        }

        private void btnStergeComanda_Click(object sender, EventArgs e)
        {
            DataSet ds = SQLConnect.ConnectDB($"delete from Mese where [Numar Comanda]={dataGridView1.SelectedCells[0].Value.ToString()}");
            
            refresh();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                btnStergeComanda.Enabled = true;
                btnStergeComanda.BackColor = Color.RosyBrown;
                btnProdusNou.Enabled = true;
                btnProdusNou.BackColor = Color.RosyBrown;
            }

            else
            {
                btnStergeComanda.Enabled = false;
                btnStergeComanda.BackColor = Color.FromArgb(128, 64, 64);
                btnProdusNou.Enabled = false;
                btnProdusNou.BackColor = Color.FromArgb(128, 64, 64);
            }
        }

        private void btnProdusNou_Click(object sender, EventArgs e)
        {
            DataSet ds = SQLConnect.ConnectDB($"update Mese set [Nota Comanda]=concat([Nota Comanda],'{((char)13 + comboBoxProdus.SelectedItem.ToString())}')  where [Numar Comanda]={dataGridView1.SelectedCells[0].Value.ToString()}");
            
            refresh();
        }
    }
}
