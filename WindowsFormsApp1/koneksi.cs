using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class koneksi
    {
        public static class Koneksi
        {
            private static string connectionString = @"Data Source=LAPTOP-83VQSOJ9;Initial Catalog=DataInformasi;TrustServerCertificate=True;Integrated Security=True;";

            public static SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }

    }
}
