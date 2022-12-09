using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS
{
    class SQLConnect
    {
        public static DataSet ConnectDB(string query)
        {
            DataSet ds = new DataSet();
            try
            {
                string connect = @"Data Source=DESKTOP-D12MC23\SQLEXPRESS;Initial Catalog=PS;Integrated Security=True";

                SqlConnection cnn = new SqlConnection(connect);
                cnn.Open();

                SqlDataAdapter da = new SqlDataAdapter(query, connect);
                
                da.Fill(ds);
                cnn.Close();
            }
            catch (Exception e)
            {
                Main main = new Main();
                main.Eroare(e.Message);
            }
            return ds;
        }
    }
}
