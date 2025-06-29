using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp1.koneksi;

namespace WindowsFormsApp1
{
    internal class InformasiService
    {
        public static void Insert(string nama, int umur, float berat, float tinggi)
        {
            using (SqlConnection con = Koneksi.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Informasi (Nama, Umur, BeratBadan, TinggiBadan) VALUES (@Nama, @Umur, @BeratBadan, @TinggiBadan)", con);
                cmd.Parameters.AddWithValue("@Nama", nama);
                cmd.Parameters.AddWithValue("@Umur", umur);
                cmd.Parameters.AddWithValue("@BeratBadan", berat);
                cmd.Parameters.AddWithValue("@TinggiBadan", tinggi);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Update(string nama, int umur, float berat, float tinggi)
        {
            using (SqlConnection con = Koneksi.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Informasi SET Umur = @Umur, BeratBadan = @BeratBadan, TinggiBadan = @TinggiBadan WHERE Nama = @Nama", con);
                cmd.Parameters.AddWithValue("@Nama", nama);
                cmd.Parameters.AddWithValue("@Umur", umur);
                cmd.Parameters.AddWithValue("@BeratBadan", berat);
                cmd.Parameters.AddWithValue("@TinggiBadan", tinggi);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Delete(string nama)
        {
            using (SqlConnection con = Koneksi.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Informasi WHERE Nama = @Nama", con);
                cmd.Parameters.AddWithValue("@Nama", nama);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetAll()
        {
            using (SqlConnection con = Koneksi.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Informasi", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                return table;
            }
        }

        public static DataTable SearchByName(string keyword)
        {
            using (SqlConnection con = Koneksi.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Informasi WHERE Nama LIKE @Nama", con);
                cmd.Parameters.AddWithValue("@Nama", "%" + keyword + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
