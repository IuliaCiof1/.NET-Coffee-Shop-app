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
            DataSet ds = SQLConnect.ConnectDB("select [Numar Comanda], [Numar Masa], Ospatar from  Mese");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnNodaComanda_Click(object sender, EventArgs e)
        {
            NoteComanda nc = new NoteComanda();
            nc.ShowDialog();
        }

        private void btnNotaPlata_Click(object sender, EventArgs e)
        {
            NotePlata np = new NotePlata();
            np.ShowDialog();
        }
    }
}
