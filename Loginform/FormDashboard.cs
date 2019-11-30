using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;//library mengatur posisi window

namespace Loginform
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        //code mengatur posisi window
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);//bahasa portugis

        private void menubtn_Click(object sender, EventArgs e)
        {
            if(Sidemenu.Width == 250)
            {
                Sidemenu.Width = 70;
            }
            else
            {
                Sidemenu.Width = 250;
            }
        }

        private void closeicon_Click(object sender, EventArgs e)
        {
            //missing icon
        }

        private void maxicon_Click(object sender, EventArgs e)
        {
            //missing icon
        }

        private void minicon_Click(object sender, EventArgs e)
        {
            //missing icon
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            //missing icon
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            //mengatur posisi window
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //pindah halaman
            FormLogin fl = new FormLogin();
            fl.Show();
            this.Hide();
        }

        public void objekPanel(object Formhijo)//bahasa portugis
        {
            //membuat objek formcustomer pada content dashboard
            if (this.Conten.Controls.Count > 0)
            
                this.Conten.Controls.RemoveAt(0);
                Form fh = Formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.Conten.Controls.Add(fh);
                this.Conten.Tag = fh;
                fh.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //menampilkan objek formcustomer pada content dashboard
            objekPanel(new FormCustomer());
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //menampilkan objek formcustomer pada content dashboard
            objekPanel(new FormTranks());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //menampilkan objek formcustomer pada content dashboard
            objekPanel(new FormAbout());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //hide window
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            //menutup program
            Application.Exit();
        }

        private void max_Click(object sender, EventArgs e)
        {
            //maximize window
            this.WindowState = FormWindowState.Maximized;
            min.Visible = true;
            max.Visible = false;
        }

        private void min_Click(object sender, EventArgs e)
        {
            //manimize window
            this.WindowState = FormWindowState.Normal;
            min.Visible = false;
            max.Visible = true;
        }

    }
}
