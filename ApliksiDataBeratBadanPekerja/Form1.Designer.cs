namespace ApliksiDataBeratBadanPekerja
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AplikasiBeratBadan = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblHasilBMI = new Label();
            txtNama = new TextBox();
            txtBerat = new TextBox();
            txtTinggi = new TextBox();
            btnHitungBMI = new Button();
            btnSimpan = new Button();
            lvPekerja = new ListView();
            SuspendLayout();
            // 
            // AplikasiBeratBadan
            // 
            AplikasiBeratBadan.BackColor = SystemColors.MenuHighlight;
            AplikasiBeratBadan.BorderStyle = BorderStyle.Fixed3D;
            AplikasiBeratBadan.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AplikasiBeratBadan.ForeColor = SystemColors.ButtonFace;
            AplikasiBeratBadan.Location = new Point(3, 9);
            AplikasiBeratBadan.Name = "AplikasiBeratBadan";
            AplikasiBeratBadan.RightToLeft = RightToLeft.No;
            AplikasiBeratBadan.Size = new Size(794, 24);
            AplikasiBeratBadan.TabIndex = 0;
            AplikasiBeratBadan.Text = "APLIKASI BERAT BADAN";
            AplikasiBeratBadan.TextAlign = ContentAlignment.TopCenter;
            AplikasiBeratBadan.Click += label1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 45);
            label1.Name = "label1";
            label1.Size = new Size(70, 23);
            label1.TabIndex = 1;
            label1.Text = "NAMA";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 82);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 2;
            label2.Text = "BERAT";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 120);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 3;
            label3.Text = "TINGGI";
            // 
            // lblHasilBMI
            // 
            lblHasilBMI.BackColor = SystemColors.MenuHighlight;
            lblHasilBMI.BorderStyle = BorderStyle.Fixed3D;
            lblHasilBMI.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblHasilBMI.ForeColor = SystemColors.ButtonFace;
            lblHasilBMI.ImageAlign = ContentAlignment.TopCenter;
            lblHasilBMI.ImageKey = "(none)";
            lblHasilBMI.Location = new Point(479, 44);
            lblHasilBMI.Name = "lblHasilBMI";
            lblHasilBMI.Size = new Size(309, 23);
            lblHasilBMI.TabIndex = 4;
            lblHasilBMI.Text = "HASIL BMI";
            lblHasilBMI.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(107, 45);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(279, 23);
            txtNama.TabIndex = 5;
            // 
            // txtBerat
            // 
            txtBerat.Location = new Point(107, 82);
            txtBerat.Name = "txtBerat";
            txtBerat.Size = new Size(279, 23);
            txtBerat.TabIndex = 6;
            txtBerat.TextChanged += textBox2_TextChanged;
            // 
            // txtTinggi
            // 
            txtTinggi.Location = new Point(107, 120);
            txtTinggi.Name = "txtTinggi";
            txtTinggi.Size = new Size(279, 23);
            txtTinggi.TabIndex = 7;
            // 
            // btnHitungBMI
            // 
            btnHitungBMI.BackColor = Color.Yellow;
            btnHitungBMI.Font = new Font("News706 BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHitungBMI.Location = new Point(107, 188);
            btnHitungBMI.Name = "btnHitungBMI";
            btnHitungBMI.Size = new Size(138, 35);
            btnHitungBMI.TabIndex = 8;
            btnHitungBMI.Text = "HITUNG BMI";
            btnHitungBMI.UseVisualStyleBackColor = false;
            btnHitungBMI.Click += button1_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Lime;
            btnSimpan.Font = new Font("News706 BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.Location = new Point(248, 188);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(138, 35);
            btnSimpan.TabIndex = 9;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += button2_Click;
            // 
            // lvPekerja
            // 
            lvPekerja.Location = new Point(479, 71);
            lvPekerja.Name = "lvPekerja";
            lvPekerja.Size = new Size(309, 309);
            lvPekerja.TabIndex = 10;
            lvPekerja.UseCompatibleStateImageBehavior = false;
            lvPekerja.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 385);
            Controls.Add(lvPekerja);
            Controls.Add(btnSimpan);
            Controls.Add(btnHitungBMI);
            Controls.Add(txtTinggi);
            Controls.Add(txtBerat);
            Controls.Add(txtNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AplikasiBeratBadan);
            Controls.Add(lblHasilBMI);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AplikasiBeratBadan;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblHasilBMI;
        private TextBox txtNama;
        private TextBox txtBerat;
        private TextBox txtTinggi;
        private Button btnHitungBMI;
        private Button btnSimpan;
        private ListView lvPekerja;
    }
}
