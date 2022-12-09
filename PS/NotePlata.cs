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
            DataSet ds = SQLConnect.ConnectDB("select * from Mese;");

            int i = 1;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                txtBox1.Text = $"{txtBox1.Text}-----------------------------------------------------\r\n" +
                    $"Comanda: {dr["Numar Comanda"].ToString()}\t" +
                    $"Masa: {dr["Numar Masa"].ToString()}\r\n" +
                    $"Ospatar: {dr["Ospatar"].ToString()}\r\n\r\n";

                DataSet ds1 = SQLConnect.ConnectDB(
                    "declare @strText as nvarchar(200);" +
                    "set @strText = (select [Nota Comanda] from (select [Nota Comanda], row_number() over (order by [Numar Comanda]) as RowNum from Mese ) as MyDerivedTable where MyDerivedTable.RowNum=" + i + "); " + //selecteaza [Nota Comanda] de pe randul i
                    "select value, p.Pret into #tempTable from STRING_SPLIT(@strText, char(13)) left join Meniu_Produse as p on value = p.Produs;" +
                    "update Mese set [Nota Plata]=(select sum(Pret) as Preturi from #tempTable) where [Nota Comanda] = @strText;" +
                    "insert into #tempTable (Pret) values ((select sum(Pret) as Preturi from #tempTable));" +
                    "select * from #tempTable");

                foreach (DataRow dr1 in ds1.Tables[0].Rows)
                {
                    if (dr1["value"].ToString() == "")
                    {
                        txtBox1.Text = $"{txtBox1.Text}\r\n\r\n" +
                        $"Total: {dr1["Pret"].ToString()}";
                        break;
                    }
                    txtBox1.Text = $"{txtBox1.Text}\r\n" +
                        $"{dr1["value"].ToString()} {dr1["Pret"].ToString()}";
                }


                i++;
            }

            txtBox1.Text = $"{txtBox1.Text}-----------------------------------------------------\r\n";

        }

        private void NotePlata_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
