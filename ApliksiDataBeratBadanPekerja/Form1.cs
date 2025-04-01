namespace ApliksiDataBeratBadanPekerja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Pastikan semua input terisi
            if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtBerat.Text) ||
                string.IsNullOrWhiteSpace(txtTinggi.Text))
            {
                MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Ambil nilai input
                string nama = txtNama.Text;
                double berat = Convert.ToDouble(txtBerat.Text);
                double tinggi = Convert.ToDouble(txtTinggi.Text);

                // Konversi tinggi ke meter jika dalam cm
                if (tinggi > 3) tinggi /= 100;

                // Hitung BMI
                double bmi = berat / (tinggi * tinggi);
                string kategori = CekKategoriBMI(bmi);

                // Tambahkan data ke ListView
                ListViewItem item = new ListViewItem(nama);
                item.SubItems.Add(berat.ToString());
                item.SubItems.Add(tinggi.ToString("F2"));
                item.SubItems.Add(bmi.ToString("F2"));
                item.SubItems.Add(kategori);
                lvPekerja.Items.Add(item);

                // Bersihkan input setelah disimpan
                txtNama.Clear();
                txtBerat.Clear();
                txtTinggi.Clear();
            }
            catch
            {
                MessageBox.Show("Pastikan berat dan tinggi dalam format angka yang benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {// Pastikan input tidak kosong
            if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtBerat.Text) ||
                string.IsNullOrWhiteSpace(txtTinggi.Text))
            {
                MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Ambil input dari TextBox
                string nama = txtNama.Text;
                double berat = Convert.ToDouble(txtBerat.Text);
                double tinggi = Convert.ToDouble(txtTinggi.Text);

                // Konversi tinggi ke meter jika dalam cm
                if (tinggi > 3) tinggi /= 100;

                // Hitung BMI
                double bmi = berat / (tinggi * tinggi);
                string kategori = CekKategoriBMI(bmi);

                // Tampilkan hasil di Label
                lblHasilBMI.Text = $"BMI: {bmi:F2} ({kategori})";

                // Tampilkan pesan hasil
                MessageBox.Show($"Nama: {nama}\nBMI: {bmi:F2}\nKategori: {kategori}", "Hasil BMI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Pastikan berat dan tinggi dalam angka yang benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fungsi untuk menentukan kategori BMI
        private string CekKategoriBMI(double bmi)
        {
            if (bmi < 18.5) return "Kurus";
            else if (bmi < 24.9) return "Normal";
            else if (bmi < 29.9) return "Gemuk";
            else return "Obesitas";

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
