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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnMeniu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Meniu meniu = new Meniu();
            meniu.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInchide_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void btnComenzi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Comenzi comanda = new Comenzi();
            comanda.ShowDialog();

        }

        private void btnIncasari_Click(object sender, EventArgs e)
        {
            this.Hide();
            Incasari inc = new Incasari();
            inc.ShowDialog();
        }

        private void btnAngajati_Click(object sender, EventArgs e)
        {
            this.Hide();
            Angajati ang = new Angajati();
            ang.ShowDialog();
        }

        public void Eroare(string er)
        {
            MessageBox.Show(er);
        }
    }
}
