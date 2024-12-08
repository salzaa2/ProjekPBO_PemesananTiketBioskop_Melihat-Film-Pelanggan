namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    partial class V_HalPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_HalPelanggan));
            pictureBox1 = new PictureBox();
            btProfil = new Button();
            btLogout = new Button();
            btRiwayat = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1374, 409);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btProfil
            // 
            btProfil.BackgroundImage = (Image)resources.GetObject("btProfil.BackgroundImage");
            btProfil.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btProfil.ForeColor = Color.PeachPuff;
            btProfil.Location = new Point(183, 82);
            btProfil.Name = "btProfil";
            btProfil.Size = new Size(160, 56);
            btProfil.TabIndex = 1;
            btProfil.Text = "Profil";
            btProfil.UseVisualStyleBackColor = true;
            btProfil.Click += btProfil_Click_1;
            // 
            // btLogout
            // 
            btLogout.BackgroundImage = (Image)resources.GetObject("btLogout.BackgroundImage");
            btLogout.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogout.ForeColor = Color.PeachPuff;
            btLogout.Location = new Point(349, 82);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(143, 56);
            btLogout.TabIndex = 2;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = true;
            btLogout.Click += btLogout_Click;
            // 
            // btRiwayat
            // 
            btRiwayat.BackgroundImage = (Image)resources.GetObject("btRiwayat.BackgroundImage");
            btRiwayat.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRiwayat.ForeColor = Color.PeachPuff;
            btRiwayat.Location = new Point(1733, 86);
            btRiwayat.Name = "btRiwayat";
            btRiwayat.Size = new Size(143, 56);
            btRiwayat.TabIndex = 3;
            btRiwayat.Text = "Riwayat";
            btRiwayat.UseVisualStyleBackColor = true;
            btRiwayat.Click += btRiwayat_Click;
            // 
            // V_HalPelanggan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1050);
            Controls.Add(btRiwayat);
            Controls.Add(btLogout);
            Controls.Add(btProfil);
            Controls.Add(pictureBox1);
            Name = "V_HalPelanggan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_HalPelanggan";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panelContainer;
        private Button btProfil;
        private Button btLogout;
        private Button btRiwayat;
    }
}