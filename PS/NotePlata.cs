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
    public partial class NotePlata : Form
    {
        public NotePlata()
        {
            InitializeComponent();
        }

        private void NotePlata_Load(object sender, EventArgs e)
        {
            DataSet ds = SQLConnect.ConnectDB("declare @strText as nvarchar(200);" +
                "set @strText = (select [Nota Comanda] from Mese);" +
                "select value, p.Produs, p.Pret from string_split(@strText,',') left join Meniu_Produse as p on value=p.Produs;");
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
