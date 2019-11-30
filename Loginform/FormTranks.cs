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
    public partial class FormTranks : Form
    {
        BarangDAO bd = new BarangDAO();
        LayananDAO ld = new LayananDAO();
        TranksDAO td = new TranksDAO();
        string id_tranksaksi;

        public FormTranks()
        {
            InitializeComponent();
        }

        void lihatSemuaData()
        {
            DataSet data = td.getData();
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "tranksaksi";
        }

        private void FormTranks_Load(object sender, EventArgs e)
        {
            lihatSemuaData();

            MySqlConnection conn = new MySqlConnection("server=localhost;database=laundry;uid=root;pwd='';");
            string selectQuery = "SELECT * FROM layanan";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {

                comboBox1.Items.Add(read.GetString("nama_layanan"));
            }

            conn.Close();

            MySqlConnection con = new MySqlConnection("server=localhost;database=laundry;uid=root;pwd='';");
            string selectQuery1 = "SELECT * FROM barang";
            con.Open();

            MySqlCommand command = new MySqlCommand(selectQuery1, con);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                comboBox2.Items.Add(reader.GetString("nama_barang"));
            }

            con.Close();

            MySqlConnection kon = new MySqlConnection("server=localhost;database=laundry;uid=root;pwd='';");
            string selectQuery2 = "SELECT * FROM user";
            kon.Open();

            MySqlCommand comand = new MySqlCommand(selectQuery2, kon);
            MySqlDataReader readed = comand.ExecuteReader();
            while (readed.Read())
            {

                comboBox3.Items.Add(readed.GetString("id_user"));
            }

            kon.Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

            id_tranksaksi = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;//ubah properties semuanya
            int.TryParse(textBox1.Text, out a);
            int.TryParse(textBox2.Text, out b);
            textBox3.Text = Convert.ToString(a * b);

            Tranksaksi t = new Tranksaksi();
            t.tgl_masuk = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            t.tgl_keluar = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            t.nama_layanan = comboBox1.Text;
            t.nama_barang = comboBox2.Text;
            t.banyak_barang = textBox1.Text;
            t.harga = textBox2.Text;
            t.total_harga = textBox3.Text;
            t.id_user = comboBox3.Text;

            td.insertData(t);
            lihatSemuaData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b;//ubah texboxnya
            int.TryParse(textBox1.Text, out a);
            int.TryParse(textBox2.Text, out b);
            textBox3.Text = Convert.ToString(a * b);

            Tranksaksi t = new Tranksaksi();
            t.tgl_masuk = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            t.tgl_keluar = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            t.nama_layanan = comboBox1.Text;
            t.nama_barang = comboBox2.Text;
            t.banyak_barang = textBox1.Text;
            t.harga = textBox2.Text;
            t.total_harga = textBox3.Text;
            t.id_user = comboBox3.Text;

            td.udpdateData(t, id_tranksaksi);
            lihatSemuaData();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure delete this transaction?", "Delete Transaction", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //hapus data
                td.deleteData(id_tranksaksi);
                lihatSemuaData();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int a, b;
            int.TryParse(textBox1.Text, out a);
            int.TryParse(textBox2.Text, out b);
            textBox3.Text = Convert.ToString(a * b);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormBarang fb = new FormBarang();
            fb.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormDashboard fd = new FormDashboard();
            fd.objekPanel(new FormTranks());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Custlist fc = new Custlist();
            fc.Show();
        }
    }
}
