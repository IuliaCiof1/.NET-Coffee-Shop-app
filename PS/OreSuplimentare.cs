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
    public partial class OreSuplimentare : Form
    {
        public OreSuplimentare()
        {
            InitializeComponent();
        }

        private void OreSuplimentare_Load(object sender, EventArgs e)
        {
            DataSet ds = SQLConnect.ConnectDB("select Nume from Angajati;");

            foreach(DataRow dr in ds.Tables[0].Rows)
                comboBox1.Items.Add(dr["Nume"].ToString());
        }
    }
}
