using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Loginform
{
    class BarangDAO
    {
        private MySqlCommand cmd;
        string conn = "server=localhost;database=laundry;uid=root;pwd='';";
        MySqlConnection konek = new MySqlConnection();

        public BarangDAO()
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
                cmd.CommandText = "SELECT id_barang, nama_barang from barang ORDER BY id_barang ASC";
                MySqlDataAdapter mdap = new MySqlDataAdapter(cmd);
                mdap.Fill(ds, "barang");
                konek.Close();
            }
            catch (MySqlException)
            {
                Console.WriteLine("gagal di dataset");
            }
            return ds;
        }

        public bool insertData(Barang b)
        {
            Boolean stat = false;
            try
            {
                konek.Open();
                cmd = new MySqlCommand();
                cmd.Connection = konek;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO barang (id_barang, nama_barang) VALUES ('" + b.id_barang + "','" + b.nama_barang + "')";
                cmd.ExecuteNonQuery();
                stat = true;
                konek.Close();
            }
            catch (MySqlException)
            {
                Console.WriteLine("gagal di insert");
            }
            return stat;
        }

        public bool deleteData(string id_barang)
        {
            Boolean stat = false;
            try
            {
                konek.Open();
                cmd = new MySqlCommand();
                cmd.Connection = konek;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM barang WHERE id_barang='" + id_barang + "'";
                cmd.ExecuteNonQuery();
                stat = true;
                konek.Close();
            }
            catch (MySqlException)
            {
                Console.WriteLine("gagal di delete");
            }
            return stat;
        }

        public bool udpdateData(Barang b, string id_barang)
        {
            Boolean stat = false;
            try
            {
                konek.Open();
                cmd = new MySqlCommand();
                cmd.Connection = konek;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE barang SET nama_barang='" + b.nama_barang + "'," + "id_barang='" + b.id_barang + "' WHERE id_barang='" + id_barang + "'";
                cmd.ExecuteNonQuery();
                stat = true;
                konek.Close();
            }
            catch (MySqlException)
            {
                Console.WriteLine("gagal di update");
            }
            return stat;
        }
    }
}
