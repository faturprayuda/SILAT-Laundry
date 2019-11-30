using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Loginform
{
    class TranksDAO
    {
        private MySqlCommand cmd;
        string conn = "server=localhost;database=laundry;uid=root;pwd='';Convert Zero Datetime=True;";
        MySqlConnection konek = new MySqlConnection();

        public TranksDAO()
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
                cmd.CommandText = "SELECT id_tranksaksi, tgl_masuk, tgl_keluar, nama_layanan, nama_barang, " +
                    "banyak_barang, harga, total_harga, id_user from tranksaksi";
                MySqlDataAdapter mdap = new MySqlDataAdapter(cmd);
                mdap.Fill(ds, "tranksaksi");
                konek.Close();
            }
            catch (MySqlException)
            {
                Console.WriteLine("gagal di dataset");
            }
            return ds;
        }

        public bool insertData(Tranksaksi tf)
        {
            Boolean stat = false;
            try
            {
                konek.Open();
                cmd = new MySqlCommand();
                cmd.Connection = konek;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO tranksaksi (tgl_masuk, tgl_keluar, nama_layanan, nama_barang, " +
                    "banyak_barang, harga, total_harga, id_user) " +
                    "VALUES ('" + tf.tgl_masuk + "','" + tf.tgl_keluar + "','" + tf.nama_layanan + "','" 
                    + tf.nama_barang + "','" + tf.banyak_barang + "','" + tf.harga + "','" + tf.total_harga + "','" + tf.id_user + "')";
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

        public bool deleteData(string id_tranksaksi)
        {
            Boolean stat = false;
            try
            {
                konek.Open();
                cmd = new MySqlCommand();
                cmd.Connection = konek;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM tranksaksi WHERE id_tranksaksi='" + id_tranksaksi + "'";
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

        public bool udpdateData(Tranksaksi t, string id_tranksaksi)
        {
            Boolean stat = false;
            try
            {
                konek.Open();
                cmd = new MySqlCommand();
                cmd.Connection = konek;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE tranksaksi SET tgl_masuk='" + t.tgl_masuk + "'," +
                    "tgl_keluar='" + t.tgl_keluar + "'," +
                    "nama_layanan='" + t.nama_layanan + "'," +
                    "nama_barang='" + t.nama_barang + "'," +
                    "banyak_barang='" + t.banyak_barang + "'," +
                    "harga='" + t.harga + "'," +
                    "total_harga='" + t.total_harga + "'," + 
                    "id_user='" + t.id_user + "' WHERE id_tranksaksi='" + id_tranksaksi + "'";
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
