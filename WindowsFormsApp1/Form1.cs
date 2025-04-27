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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-83VQSOJ9;Initial Catalog=DataInformasi;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Informasi (Nama, Umur, BeratBadan, TinggiBadan) VALUES (@Nama, @Umur, @BeratBadan, @TinggiBadan)", con);
            cmd.Parameters.AddWithValue("@Nama", textBox1.Text);
            cmd.Parameters.AddWithValue("@Umur", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@BeratBadan", float.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@TinggiBadan", float.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully!"); // Lebih baik menggunakan "Updated" untuk operasi update

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-83VQSOJ9;Initial Catalog=DataInformasi;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete Informasi where Nama=@Nama", con);
            cnn.Parameters.AddWithValue("@Nama", textBox1.Text); // Kirim sebagai string
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-83VQSOJ9;Initial Catalog=DataInformasi;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Informasi (Nama, Umur, BeratBadan, TinggiBadan) VALUES (@Nama, @Umur, @BeratBadan, @TinggiBadan)", con);
            cmd.Parameters.AddWithValue("@Nama", textBox1.Text);
            cmd.Parameters.AddWithValue("@Umur", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@BeratBadan", float.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@TinggiBadan", float.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-83VQSOJ9;Initial Catalog=DataInformasi;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from Informasi", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
