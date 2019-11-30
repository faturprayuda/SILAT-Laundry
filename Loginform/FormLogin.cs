using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Loginform
{
    public partial class FormLogin : Form
    {
        cekAdmin cek = new cekAdmin();//objek pada kelas cekadmin
        private MySqlConnection konek = new MySqlConnection();//objek untuk membuat koneksi pada db

        public FormLogin()
        {
            InitializeComponent();
            removeBG(txticon2, icon2);
        }

        void removeBG(PictureBox pb, PictureBox pb2)
        {
            var pos = this.PointToScreen(pb2.Location);
            pos = pb.PointToClient(pos);
            pb2.Parent = pb;
            pb2.Location = pos;
            pb2.BackColor = Color.Transparent;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            icon.BackgroundImage = Properties.Resources.username;
            textBox1.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.PasswordChar = '*';
            icon2.BackgroundImage = Properties.Resources.password;
            textBox2.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void closeicon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;

            if (user == "" || pass == "")
            {
                MessageBox.Show("Username dan Password Tidak Boleh Kosong");
                return;
            }
            bool r = cek.validate_login(user, pass);
            if (r)
            {
                FormDashboard fd = new FormDashboard();
                fd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah");
            }
        }
    }
}
