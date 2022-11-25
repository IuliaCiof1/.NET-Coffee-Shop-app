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
            //CAFEA
            DisplayList(SQLConnect.ConnectDB("select Produs, Pret, Gramaj from Meniu_Produse where Categorie='Cafea'"), listBoxCafea);
            DisplayList(SQLConnect.ConnectDB("select Produs, Pret, Gramaj from Meniu_Produse where Categorie='Ceai'"), listBoxCeai);
            DisplayList(SQLConnect.ConnectDB("select Produs, Pret, Gramaj from Meniu_Produse where Categorie='Suc'"), listBoxSuc);
            DisplayList(SQLConnect.ConnectDB("select Produs, Pret, Gramaj from Meniu_Produse where Categorie='Desert'"), listBoxDesert);
        }

        private void DisplayList(DataSet d, ListBox listBox)
        {
            List<string> list = new List<string>();
            foreach (DataRow dataRow in d.Tables[0].Rows)
            {
                list.Add(dataRow["Produs"].ToString() + "...................." + dataRow["Pret"].ToString() +
                    "lei...................." + dataRow["Gramaj"].ToString() + "g");
            }
            listBox.DataSource = list;
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }
    }
}
