
namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    partial class V_DetailFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_DetailFilm));
            btLanjut = new Button();
            lblGenre = new Label();
            lblSutradara = new Label();
            lblCast = new Label();
            lblDurasi = new Label();
            lblProduksi = new Label();
            lblSinopsis = new Label();
            pbPosterFilm = new PictureBox();
            lblJudulFilm = new Label();
            btLogout = new Button();
            btRiwayat = new Button();
            btProfil = new Button();
            ((System.ComponentModel.ISupportInitialize)pbPosterFilm).BeginInit();
            SuspendLayout();
            // 
            // btLanjut
            // 
            btLanjut.BackColor = Color.White;
            btLanjut.BackgroundImage = (Image)resources.GetObject("btLanjut.BackgroundImage");
            btLanjut.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLanjut.ForeColor = SystemColors.ActiveCaptionText;
            btLanjut.Location = new Point(1303, 944);
            btLanjut.Name = "btLanjut";
            btLanjut.Size = new Size(413, 94);
            btLanjut.TabIndex = 0;
            btLanjut.Text = "  Lanjut";
            btLanjut.UseVisualStyleBackColor = false;
            btLanjut.Click += btLanjut_Click;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(921, 420);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(57, 25);
            lblGenre.TabIndex = 1;
            lblGenre.Text = "genre";
            lblGenre.Click += label1_Click_1;
            // 
            // lblSutradara
            // 
            lblSutradara.AutoSize = true;
            lblSutradara.Location = new Point(921, 461);
            lblSutradara.Name = "lblSutradara";
            lblSutradara.Size = new Size(86, 25);
            lblSutradara.TabIndex = 2;
            lblSutradara.Text = "sutradara";
            // 
            // lblCast
            // 
            lblCast.AutoSize = true;
            lblCast.Location = new Point(921, 505);
            lblCast.Name = "lblCast";
            lblCast.Size = new Size(43, 25);
            lblCast.TabIndex = 3;
            lblCast.Text = "cast";
            // 
            // lblDurasi
            // 
            lblDurasi.AutoSize = true;
            lblDurasi.Location = new Point(921, 546);
            lblDurasi.Name = "lblDurasi";
            lblDurasi.Size = new Size(60, 25);
            lblDurasi.TabIndex = 4;
            lblDurasi.Text = "durasi";
            // 
            // lblProduksi
            // 
            lblProduksi.AutoSize = true;
            lblProduksi.Location = new Point(921, 587);
            lblProduksi.Name = "lblProduksi";
            lblProduksi.Size = new Size(82, 25);
            lblProduksi.TabIndex = 5;
            lblProduksi.Text = "produksi";
            // 
            // lblSinopsis
            // 
            lblSinopsis.AutoSize = true;
            lblSinopsis.Location = new Point(921, 630);
            lblSinopsis.Name = "lblSinopsis";
            lblSinopsis.Size = new Size(76, 25);
            lblSinopsis.TabIndex = 6;
            lblSinopsis.Text = "sinopsis";
            // 
            // pbPosterFilm
            // 
            pbPosterFilm.Location = new Point(228, 408);
            pbPosterFilm.Name = "pbPosterFilm";
            pbPosterFilm.Size = new Size(314, 408);
            pbPosterFilm.TabIndex = 7;
            pbPosterFilm.TabStop = false;
            // 
            // lblJudulFilm
            // 
            lblJudulFilm.AutoSize = true;
            lblJudulFilm.Location = new Point(118, 306);
            lblJudulFilm.Name = "lblJudulFilm";
            lblJudulFilm.Size = new Size(86, 25);
            lblJudulFilm.TabIndex = 8;
            lblJudulFilm.Text = "judul film";
            // 
            // btLogout
            // 
            btLogout.BackgroundImage = (Image)resources.GetObject("btLogout.BackgroundImage");
            btLogout.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogout.ForeColor = Color.PeachPuff;
            btLogout.Location = new Point(349, 82);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(143, 56);
            btLogout.TabIndex = 10;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = true;
            btLogout.Click += btLogout_Click_1;
            // 
            // btRiwayat
            // 
            btRiwayat.BackgroundImage = (Image)resources.GetObject("btRiwayat.BackgroundImage");
            btRiwayat.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRiwayat.ForeColor = Color.PeachPuff;
            btRiwayat.Location = new Point(1733, 86);
            btRiwayat.Name = "btRiwayat";
            btRiwayat.Size = new Size(143, 56);
            btRiwayat.TabIndex = 11;
            btRiwayat.Text = "Riwayat";
            btRiwayat.UseVisualStyleBackColor = true;
            btRiwayat.Click += btRiwayat_Click_1;
            // 
            // btProfil
            // 
            btProfil.BackgroundImage = (Image)resources.GetObject("btProfil.BackgroundImage");
            btProfil.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btProfil.ForeColor = Color.PeachPuff;
            btProfil.Location = new Point(183, 82);
            btProfil.Name = "btProfil";
            btProfil.Size = new Size(160, 56);
            btProfil.TabIndex = 12;
            btProfil.Text = "Profil";
            btProfil.UseVisualStyleBackColor = true;
            btProfil.Click += btProfil_Click;
            // 
            // V_DetailFilm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1050);
            Controls.Add(btProfil);
            Controls.Add(btRiwayat);
            Controls.Add(btLogout);
            Controls.Add(lblJudulFilm);
            Controls.Add(pbPosterFilm);
            Controls.Add(lblSinopsis);
            Controls.Add(lblProduksi);
            Controls.Add(lblDurasi);
            Controls.Add(lblCast);
            Controls.Add(lblSutradara);
            Controls.Add(lblGenre);
            Controls.Add(btLanjut);
            Name = "V_DetailFilm";
            Text = "DetailFilm";
            ((System.ComponentModel.ISupportInitialize)pbPosterFilm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btLanjut;
        private Label lblGenre;
        private Label lblSutradara;
        private Label lblCast;
        private Label lblDurasi;
        private Label lblProduksi;
        private Label lblSinopsis;
        private PictureBox pbPosterFilm;
        private Label lblJudulFilm;
        private Button button1;
        private Button btRiwayat;
        private Button btLogout;
        private Button btProfil;
    }
}