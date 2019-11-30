using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//koneksi database Mysql

namespace Loginform
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        UserDAO UD = new UserDAO();//objek UserDao
        string id_user;

        void lihatSemuaData()
        {//menampilkan data
            DataSet data = UD.getData();
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "user";
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            lihatSemuaData();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //menampilkan data db ke textbox
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            id_user = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //input data
            User u = new User();
            u.nama_user = textBox1.Text;
            u.alamat_user = textBox2.Text;
            u.no_user = textBox3.Text;

            UD.insertData(u);
            lihatSemuaData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ubah data
            User u = new User();
            u.nama_user = textBox1.Text;
            u.alamat_user = textBox2.Text;
            u.no_user = textBox3.Text;
            UD.udpdateData(u, id_user);
            lihatSemuaData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure delete this customer?", "Delete Customer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //hapus data
                UD.deleteData(id_user);
                lihatSemuaData();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something
            }

        }
    }
}
