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
    public partial class Incasari : Form
    {
        public Incasari()
        {
            InitializeComponent();
        }

        private void Incasari_Load(object sender, EventArgs e)
        {
            DataSet ds = SQLConnect.ConnectDB("select Nume, sum(m.[Nota Plata]) as Total from Angajati full join Mese as m on m.Ospatar=Nume where Functie='Ospatar' group by Nume;");

            dataGridView1.DataSource = ds.Tables[0];
            
            ds = SQLConnect.ConnectDB("select sum(Total) as Total from (select sum(m.[Nota Plata]) as Total from Angajati full join Mese as m on m.Ospatar=Nume where Functie='Ospatar' group by Nume) as a;");
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }
    }
}
