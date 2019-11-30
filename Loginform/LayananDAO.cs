using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Loginform
{
    class LayananDAO
    {
        private MySqlCommand cmd;
        string conn = "server=localhost;database=laundry;uid=root;pwd='';";
        MySqlConnection konek = new MySqlConnection();

        public LayananDAO()
        {
            konek.ConnectionString = conn;
        }

        public DataSet getData()
        {
            DataSet ds = new DataSet();
            try
            {
                cmd = new MySqlCommand();
                cmd.Connection = konek;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT id_layanan, nama_layanan from layanan";
                MySqlDataAdapter mdap = new MySqlDataAdapter(cmd);
                mdap.Fill(ds, "layanan");
                konek.Close();
            }
            catch (MySqlException)
            {
                Console.WriteLine("gagal di dataset");
            }
            return ds;
        }
    }
}
