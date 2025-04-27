![{2380BE63-8FE0-4389-83D1-3DBF6EBDF876}](https://github.com/user-attachments/assets/a73fcf25-3fc5-4cc9-8e3c-39e6d38fb3d1)


#Aplikasi Pengelolaan Data Informasi
Aplikasi ini adalah aplikasi berbasis Windows Forms yang dibangun dengan menggunakan bahasa pemrograman C# dan SQL Server. Aplikasi ini memungkinkan pengguna untuk mengelola data informasi seperti nama, umur, berat badan, dan tinggi badan dalam database SQL. Aplikasi ini memiliki fitur untuk menambah, mengedit, menghapus, dan menampilkan data dari database.

#Fitur Aplikasi
Menyimpan Data

Pengguna dapat memasukkan data baru berupa Nama, Umur, Berat Badan, dan Tinggi Badan.

Data yang dimasukkan akan disimpan ke dalam database SQL di tabel Informasi.

Menampilkan Data

Pengguna dapat melihat semua data yang tersimpan dalam tabel Informasi di dalam database.

Data akan ditampilkan dalam bentuk tabel pada DataGridView.

Mengupdate Data

Pengguna dapat mengupdate data berdasarkan Nama yang dimasukkan. Jika data ditemukan, data akan diupdate dengan informasi yang baru.

Menghapus Data

Pengguna dapat menghapus data berdasarkan Nama yang dimasukkan. Data yang dihapus akan dihapus dari tabel Informasi di database.

#Teknologi yang Digunakan
Bahasa Pemrograman: C#
Platform: Windows Forms (WinForms)
Database: SQL Server
SQL: Untuk operasi CRUD (Create, Read, Update, Delete)

#Instalasi
Persyaratan Sistem

Pastikan Anda memiliki SQL Server yang terinstal di sistem Anda.

Pastikan koneksi database sudah benar sesuai dengan konfigurasi yang ada pada aplikasi.

Langkah Instalasi

Clone atau download repository ini ke komputer Anda.

Buka proyek ini menggunakan Visual Studio.

Sesuaikan koneksi database pada kode program, khususnya di bagian string koneksi:

csharp
Salin
Edit
SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-83VQSOJ9;Initial Catalog=DataInformasi;TrustServerCertificate=True;Integrated Security=True;");
Pastikan database yang disebutkan dalam string koneksi (DataInformasi) sudah ada di SQL Server Anda dan tabel Informasi sudah dibuat dengan struktur yang sesuai.

#Menjalankan Aplikasi

Setelah pengaturan selesai, tekan tombol Start di Visual Studio untuk menjalankan aplikasi.

Aplikasi akan terbuka dan Anda bisa mulai menggunakan fitur-fitur yang tersedia.

#Struktur Database
Tabel Informasi di database DataInformasi harus memiliki struktur sebagai berikut:


Nama Kolom	Tipe Data
Nama	VARCHAR
Umur	INT
BeratBadan	FLOAT
TinggiBadan	FLOAT
Cara Penggunaan
Menyimpan Data:

Masukkan Nama, Umur, Berat Badan, dan Tinggi Badan pada kolom yang sesuai.

Klik tombol Simpan untuk menyimpan data ke dalam database.

Menampilkan Data:

Klik tombol Tampilkan Data untuk melihat semua data yang tersimpan dalam tabel Informasi.

Mengupdate Data:

Masukkan Nama yang datanya ingin diubah, dan perbarui informasi yang diperlukan.

Klik tombol Update untuk menyimpan perubahan.

Menghapus Data:

Masukkan Nama yang datanya ingin dihapus.

Klik tombol Hapus untuk menghapus data dari database.

#Kontak
Jika Anda memiliki pertanyaan atau masalah terkait aplikasi ini, Anda bisa menghubungi pengembang melalui email di [your-email@example.com].
