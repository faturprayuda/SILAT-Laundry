using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Loginform
{
    class UserDAO
    {
        private MySqlCommand cmd;
        string conn = "server=localhost;database=laundry;uid=root;pwd='';";
        MySqlConnection konek = new MySqlConnection();

        public UserDAO()
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
                cmd.CommandText = "SELECT id_user, nama_user, alamat_user, no_user from user";
                MySqlDataAdapter mdap = new MySqlDataAdapter(cmd);
                mdap.Fill(ds, "user");
                konek.Close();
            }
            catch (MySqlException)
            {
                Console.WriteLine("gagal di dataset");
            }
            return ds;
        }

        public bool insertData(User u)
        {
            Boolean stat = false;
            try
            {
                konek.Open();
                cmd = new MySqlCommand();
                cmd.Connection = konek;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO user (nama_user, alamat_user, no_user) VALUES ('" + u.nama_user + "','" + u.alamat_user + "','" + u.no_user + "')";
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

        public bool deleteData(string id_user)
        {
            Boolean stat = false;
            try
            {
                konek.Open();
                cmd = new MySqlCommand();
                cmd.Connection = konek;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM user WHERE id_user='" + id_user + "'";
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

        public bool udpdateData(User u, string id_user)
        {
            Boolean stat = false;
            try
            {
                konek.Open();
                cmd = new MySqlCommand();
                cmd.Connection = konek;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE user SET nama_user='" + u.nama_user + "'," + "alamat_user='" + u.alamat_user + "'," +
                    "no_user='" + u.no_user + "' WHERE id_user='" + id_user + "'";
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
