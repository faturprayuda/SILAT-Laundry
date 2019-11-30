using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Loginform
{
    class cekAdmin
    {
        private MySqlConnection konek = new MySqlConnection();
        public bool validate_login(string user, string pass)
        {
            string conn = "server=localhost;database=laundry;uid=root;pwd='';";
            konek = new MySqlConnection(conn);
            konek.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from admin where user_pegawai=@id_pegawai and password_pegawai=@password_pegawai";
            cmd.Parameters.AddWithValue("@id_pegawai", user);
            cmd.Parameters.AddWithValue("@password_pegawai", pass);
            cmd.Connection = konek;
            MySqlDataReader login = cmd.ExecuteReader();

            if (login.Read())
            {
                konek.Close();
                return true;
            }
            else
            {
                konek.Close();
                return false;
            }
        }
    }
}
