using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.models;

namespace WindowsFormsApp1.Repositories
{
    public class InformasiRepository
    {
        public static void Insert(Informasi info)
        {
            using (SqlConnection con = koneksi.Koneksi.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Informasi (Nama, Umur, BeratBadan, TinggiBadan) VALUES (@Nama, @Umur, @Berat, @Tinggi)", con);
                cmd.Parameters.AddWithValue("@Nama", info.Nama);
                cmd.Parameters.AddWithValue("@Umur", info.Umur);
                cmd.Parameters.AddWithValue("@Berat", info.BeratBadan);
                cmd.Parameters.AddWithValue("@Tinggi", info.TinggiBadan);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Update(Informasi info)
        {
            using (SqlConnection con = koneksi.Koneksi.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Informasi SET Umur = @Umur, BeratBadan = @Berat, TinggiBadan = @Tinggi WHERE Nama = @Nama", con);
                cmd.Parameters.AddWithValue("@Nama", info.Nama);
                cmd.Parameters.AddWithValue("@Umur", info.Umur);
                cmd.Parameters.AddWithValue("@Berat", info.BeratBadan);
                cmd.Parameters.AddWithValue("@Tinggi", info.TinggiBadan);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Delete(string nama)
        {
            using (SqlConnection con = koneksi.Koneksi.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Informasi WHERE Nama = @Nama", con);
                cmd.Parameters.AddWithValue("@Nama", nama);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetAll()
        {
            using (SqlConnection con = koneksi.Koneksi.GetConnection())
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
            using (SqlConnection con = koneksi.Koneksi.GetConnection())
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
