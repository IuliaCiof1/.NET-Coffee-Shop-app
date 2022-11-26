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
            //ALTER DATABASE [DatabaseName] SET COMPATIBILITY_LEVEL = 130 // ca sa mearga string_split
            DataSet ds = SQLConnect.ConnectDB(
                "declare @strText as nvarchar(200);" +
                //"select [Nota Plata] from Mese;" +
                //"insert into Mese ([Nota Plata]) select Pret from Meniu_Produse where Produs=STRING_SPLIT(@strText,',');" +
                //"select value, p.Pret from STRING_SPLIT(@strText,',') "+
                //"set @strText = (select [Nota Comanda] from Mese);" +
                //"select value, p.Pret from STRING_SPLIT(@strText,',') left join Meniu_Produse as p on value=p.Produs;"+
        
                "declare @plataString as varchar(300)" +
                "set @plataString = stuff(" +
                    "select ',' + Pret from " +
                        "select value, p.Pret from STRING_SPLIT(@strText, ',') left join Meniu_Produse as p on value = p.Produs " +
                    "for xml path('')" +
                "), 1, 1, '')"+
                "insert into Mese ([Nota Plata]) values(@plataString)" +
            "select value, p.Produs, p.Pret, m.[Numar Comanda], m.[Numar Masa], m.Ospatar from STRING_SPLIT(@strText,',') left join Meniu_Produse as p on value=p.Produs left join Mese as m on @strText=m.[Nota Comanda];");
            dataGridView1.DataSource = ds.Tables[0];

            //foreach (DataRow dr in ds.Tables[0].Rows) {
            //    txtBox1.Text = $"{txtBox1.Text}-----------------------------------------------------\r\n" +
            //        $"Comanda: {dr["Numar Comanda"].ToString()}\t" +
            //        $"Masa: {dr["Numar Masa"].ToString()}\r\n" +
            //        $"Ospatar: {dr["Ospatar"].ToString()}\r\n\r\n" +
            //        $"{dr["Produs"].ToString()}\t{dr["Pret"].ToString()}\r\n";
            //      }
        }
    }
}
