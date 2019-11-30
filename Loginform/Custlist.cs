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
    public partial class Custlist : Form
    {
        //code mengatur posisi window
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);//bahasa portugis

        public Custlist()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        UserDAO UD = new UserDAO();//objek UserDao
        string id_user;

        void lihatSemuaData()
        {//menampilkan data
            DataSet data = UD.getData();
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "user";
        }

        private void Custlist_Load(object sender, EventArgs e)
        {
            lihatSemuaData();
        }

        private void closeicon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //mengatur posisi window
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            //mengatur posisi window
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
