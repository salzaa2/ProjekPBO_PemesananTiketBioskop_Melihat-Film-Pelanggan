namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    partial class V_DetailFilm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_DetailFilm2));
            cbPilihRuangan = new ComboBox();
            cbPilihKursi = new ComboBox();
            lblHarga = new Label();
            pictureBox1 = new PictureBox();
            lblJudulFilm = new Label();
            btLanjut = new Button();
            btProfil = new Button();
            btLogout = new Button();
            btRiwayatPesanan = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbPilihRuangan
            // 
            cbPilihRuangan.Font = new Font("Candara", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbPilihRuangan.FormattingEnabled = true;
            cbPilihRuangan.Items.AddRange(new object[] { "A", "B", "C" });
            cbPilihRuangan.Location = new Point(946, 508);
            cbPilihRuangan.Name = "cbPilihRuangan";
            cbPilihRuangan.Size = new Size(245, 47);
            cbPilihRuangan.TabIndex = 0;
            cbPilihRuangan.Text = "Pilih Ruangan";
            // 
            // cbPilihKursi
            // 
            cbPilihKursi.Font = new Font("Candara", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbPilihKursi.FormattingEnabled = true;
            cbPilihKursi.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56" });
            cbPilihKursi.Location = new Point(946, 426);
            cbPilihKursi.Name = "cbPilihKursi";
            cbPilihKursi.Size = new Size(182, 47);
            cbPilihKursi.TabIndex = 1;
            cbPilihKursi.Text = "Pilih";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(946, 603);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(60, 25);
            lblHarga.TabIndex = 2;
            lblHarga.Text = "Harga";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(225, 370);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 405);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblJudulFilm
            // 
            lblJudulFilm.AutoSize = true;
            lblJudulFilm.Location = new Point(125, 267);
            lblJudulFilm.Name = "lblJudulFilm";
            lblJudulFilm.Size = new Size(86, 25);
            lblJudulFilm.TabIndex = 4;
            lblJudulFilm.Text = "judul film";
            // 
            // btLanjut
            // 
            btLanjut.BackgroundImage = (Image)resources.GetObject("btLanjut.BackgroundImage");
            btLanjut.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLanjut.Location = new Point(1301, 953);
            btLanjut.Name = "btLanjut";
            btLanjut.Size = new Size(417, 85);
            btLanjut.TabIndex = 5;
            btLanjut.Text = "Lanjut";
            btLanjut.UseVisualStyleBackColor = true;
            btLanjut.Click += btLanjut_Click;
            // 
            // btProfil
            // 
            btProfil.BackgroundImage = (Image)resources.GetObject("btProfil.BackgroundImage");
            btProfil.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btProfil.ForeColor = Color.PeachPuff;
            btProfil.Location = new Point(183, 82);
            btProfil.Name = "btProfil";
            btProfil.Size = new Size(160, 56);
            btProfil.TabIndex = 6;
            btProfil.Text = "Profil";
            btProfil.UseVisualStyleBackColor = true;
            btProfil.Click += btProfil_Click;
            // 
            // btLogout
            // 
            btLogout.BackgroundImage = (Image)resources.GetObject("btLogout.BackgroundImage");
            btLogout.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogout.ForeColor = Color.PeachPuff;
            btLogout.Location = new Point(349, 82);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(143, 56);
            btLogout.TabIndex = 7;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = true;
            btLogout.Click += btLogout_Click;
            // 
            // btRiwayatPesanan
            // 
            btRiwayatPesanan.BackgroundImage = (Image)resources.GetObject("btRiwayatPesanan.BackgroundImage");
            btRiwayatPesanan.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRiwayatPesanan.ForeColor = Color.PeachPuff;
            btRiwayatPesanan.Location = new Point(1733, 86);
            btRiwayatPesanan.Name = "btRiwayatPesanan";
            btRiwayatPesanan.Size = new Size(143, 56);
            btRiwayatPesanan.TabIndex = 8;
            btRiwayatPesanan.Text = "Riwayat";
            btRiwayatPesanan.UseVisualStyleBackColor = true;
            btRiwayatPesanan.Click += btRiwayatPesanan_Click;
            // 
            // V_DetailFilm2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1050);
            Controls.Add(btRiwayatPesanan);
            Controls.Add(btLogout);
            Controls.Add(btProfil);
            Controls.Add(btLanjut);
            Controls.Add(lblJudulFilm);
            Controls.Add(pictureBox1);
            Controls.Add(lblHarga);
            Controls.Add(cbPilihKursi);
            Controls.Add(cbPilihRuangan);
            Name = "V_DetailFilm2";
            Text = "FormV_DetailForm2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbPilihRuangan;
        private ComboBox cbPilihKursi;
        private Label lblHarga;
        private PictureBox pictureBox1;
        private Label lblJudulFilm;
        private Button btLanjut;
        private Button btProfil;
        private Button btLogout;
        private Button btRiwayatPesanan;
    }
}