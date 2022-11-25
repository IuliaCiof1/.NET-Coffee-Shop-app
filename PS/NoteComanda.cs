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
    public partial class NoteComanda : Form
    {
        public NoteComanda()
        {
            InitializeComponent();
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
          
        }

        private void NoteComanda_Load(object sender, EventArgs e)
        {
            DataSet ds = SQLConnect.ConnectDB("select * from Mese");
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                txtBox1.Text = $"{txtBox1.Text}-----------------------------------------------------\r\n" +
                    $"Comanda: {dr["Numar Comanda"].ToString()}\t" +
                    $"Masa: {dr["Numar Masa"].ToString()}\r\n" +
                    $"Ospatar: {dr["Ospatar"].ToString()}\r\n\r\n";
                string []items = dr["Nota Comanda"].ToString().Split(',');
                foreach(string item in items)
                {
                    txtBox1.Text = txtBox1.Text + item + "\r\n";
                }
            }
        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
