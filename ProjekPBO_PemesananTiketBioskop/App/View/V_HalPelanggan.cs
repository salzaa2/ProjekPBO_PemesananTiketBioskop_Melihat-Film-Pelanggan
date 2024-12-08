using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProjekPBO_PemesananTiketBioskop.App.Context;
using ProjekPBO_PemesananTiketBioskop.App.Model;

namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    public partial class V_HalPelanggan : Form
    {
        private FlowLayoutPanel panelFilm;
        private ComboBox filterComboBox;

        public V_HalPelanggan()
        {
            InitializeComponent();
            InitializePanelFilm();
            InitializeFilterComboBox();
            LoadFilmItems(); // Memuat semua film secara default
            this.Resize += (s, e) => panelFilm.Invalidate(); // Refresh layout saat form di-resize
        }

        private void InitializePanelFilm()
        {
            panelFilm = new FlowLayoutPanel
            {
                AutoScroll = true,
                Location = new Point(0, 370),
                Size = new Size(1920, 1080),
                BorderStyle = BorderStyle.None,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                Padding = new Padding(10),
                BackColor = Color.Transparent,
            };
            this.Controls.Add(panelFilm);
        }

        private void InitializeFilterComboBox()
        {
            filterComboBox = new ComboBox
            {
                Location = new Point(1491, 99),
                Height = 35,
                Width = 200,
                Font = new Font("Britannic Bold", 12),
                BackColor = Color.MidnightBlue,
                ForeColor = Color.White,
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            filterComboBox.Items.AddRange(new string[] { "Semua Usia", "Usia 13+", "Usia 17+" });
            filterComboBox.SelectedIndex = 0; // Default ke "Semua Usia"
            filterComboBox.SelectedIndexChanged += FilterComboBox_SelectedIndexChanged;

            this.Controls.Add(filterComboBox);
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = filterComboBox.SelectedItem.ToString();
            if (selectedFilter == "Usia 13+")
                LoadFilmItems("13+");
            else if (selectedFilter == "Usia 17+")
                LoadFilmItems("17+");
            else
                LoadFilmItems();
        }

        private void LoadFilmItems(string filterUsia = "all")
        {
            panelFilm.Controls.Clear(); // Bersihkan panel sebelum menambahkan film

            // Panggil metode statis dari C_Film
            List<M_Film> filmList = C_film.GetFilmsByFilter(filterUsia);

            foreach (var film in filmList)
            {
                Panel filmItem = new Panel
                {
                    Size = new Size(312, 470),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(40)
                };

                // Gambar film
                PictureBox pictureBox = new PictureBox
                {
                    Image = film.gambar != null ? Image.FromStream(new MemoryStream(film.gambar)) : Properties.Resources.imgapp,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Top,
                    Height = 400,
                };

                // Label judul film
                Label lblJudulFilm = new Label
                {
                    Text = film.judul_film,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Britannic", 10, FontStyle.Bold),
                    BackColor = Color.MintCream,
                };

                // Tombol pilih
                Button btnPilih = new Button
                {
                    Text = "Pilih",
                    Dock = DockStyle.Bottom,
                    BackColor = ColorTranslator.FromHtml("#4CAF50"),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Height = 40,
                };

                btnPilih.Click += (s, e) =>
                {
                    MessageBox.Show($"Film dengan ID {film.film_id} dipilih!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    V_DetailFilm formDetailFilm = new V_DetailFilm(film.film_id);
                    formDetailFilm.Show();
                    this.Hide();
                };

                // Tambahkan kontrol ke panel item film
                filmItem.Controls.Add(pictureBox);
                filmItem.Controls.Add(lblJudulFilm);
                filmItem.Controls.Add(btnPilih);

                // Tambahkan item film ke panel utama
                panelFilm.Controls.Add(filmItem);
            }
        }

        private void btProfil_Click_1(object sender, EventArgs e)
        {
            V_Profil formProfil = new V_Profil(); // Membuat instance dari form V_Profil
            formProfil.Show(); // Menampilkan form V_Profil
            this.Hide(); // Menyembunyikan form saat ini (form yang berisi button btProfil)
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            V_Login formLogin = new V_Login();
            formLogin.Show();
            this.Hide();
        }

        private void btRiwayat_Click(object sender, EventArgs e)
        {
            V_RiwayatPesanan formRiwayatPesanan = new V_RiwayatPesanan();
            formRiwayatPesanan.Show();
            this.Hide();
        }
    }
}
