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
    public partial class Meniu : Form
    {
        public Meniu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataSet ds=  SQLConnect.ConnectDB("select * from Meniu_Produse order by Categorie;");
            DisplayList(ds);
        }

        private void DisplayList(DataSet ds)
        { 
            richTextBox1.Clear();
            string categorie = null;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (categorie != dr["Categorie"].ToString())
                {
                    categorie = dr["Categorie"].ToString();

                    richTextBox1.AppendText("\n  ==== " + dr["Categorie"].ToString() + " ====\n  " + dr["Produs"].ToString() + "...................." + dr["Pret"].ToString() +
                    "lei...................." + dr["Gramaj"].ToString() + "g\n");
                    richTextBox1.Select(richTextBox1.Find(categorie), categorie.Length);
                    richTextBox1.SelectionFont = new Font("Segoe Print", 14, FontStyle.Bold);
                }
                else
                {
                    richTextBox1.AppendText("  " + dr["Produs"].ToString() + "...................." + dr["Pret"].ToString() +
                   "lei...................." + dr["Gramaj"].ToString() + "g\n");
                }
            }
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void btnCafea_Click(object sender, EventArgs e)
        {
            DataSet ds = SQLConnect.ConnectDB("select * from Meniu_Produse where Categorie='Cafea';");
            DisplayList(ds);
        }

        private void btnCeai_Click(object sender, EventArgs e)
        {
            DataSet ds = SQLConnect.ConnectDB("select * from Meniu_Produse where Categorie='Ceai';");
            DisplayList(ds);
        }

        private void btnDesert_Click(object sender, EventArgs e)
        {
            DataSet ds = SQLConnect.ConnectDB("select * from Meniu_Produse where Categorie='Desert';");
            DisplayList(ds);
        }

        private void btnSuc_Click(object sender, EventArgs e)
        {
            DataSet ds = SQLConnect.ConnectDB("select * from Meniu_Produse where Categorie='Suc';");
            DisplayList(ds);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = SQLConnect.ConnectDB("select * from Meniu_Produse order by Categorie;");
            DisplayList(ds);
        }
    }
}
