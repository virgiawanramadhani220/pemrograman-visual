using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.koneksi;

namespace WindowsFormsApp1
{
    public partial class FormuUtama : Form
    {
        public FormuUtama()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = Koneksi.GetConnection())
            {
                InformasiService.Update(textBox1.Text, int.Parse(textBox2.Text), float.Parse(textBox3.Text), float.Parse(textBox4.Text));
                MessageBox.Show("Record Updated Successfully!");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = Koneksi.GetConnection())
            {
                InformasiService.Delete(textBox1.Text);
                MessageBox.Show("Record Deleted Successfully!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = Koneksi.GetConnection())
            {
                InformasiService.Insert(textBox1.Text, int.Parse(textBox2.Text), float.Parse(textBox3.Text), float.Parse(textBox4.Text));
                MessageBox.Show("Record Saved Successfully!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = Koneksi.GetConnection())
            {
                dataGridView1.DataSource = InformasiService.GetAll();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string keyword = textBox5.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Masukkan nama yang ingin dicari.");
                return;
            }
            dataGridView1.DataSource = InformasiService.SearchByName(keyword);
        }
    }
}
