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
    public partial class FormBarang : Form
    {
        public FormBarang()
        {
            InitializeComponent();
        }

        //code mengatur posisi window
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);//bahasa portugis

        BarangDAO bd = new BarangDAO();
        string id_barang;

        void lihatSemuaData()
        {
            DataSet data = bd.getData();
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "barang";
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            id_barang = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void closeicon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Barang b = new Barang();
            b.id_barang = textBox1.Text;
            b.nama_barang = textBox2.Text;

            bd.insertData(b);
            lihatSemuaData();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Barang b = new Barang();
            b.id_barang = textBox1.Text;
            b.nama_barang = textBox2.Text;
            bd.udpdateData(b, id_barang);
            lihatSemuaData();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure delete this clothes?", "Delete Clothes", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //hapus data
                bd.deleteData(id_barang);
                lihatSemuaData();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something
            }
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            lihatSemuaData();
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
