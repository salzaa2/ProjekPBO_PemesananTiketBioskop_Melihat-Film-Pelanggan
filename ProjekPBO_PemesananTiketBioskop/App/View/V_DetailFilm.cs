using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ProjekPBO_PemesananTiketBioskop.App.Model;
using static System.Net.WebRequestMethods;
using Npgsql;

namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    public partial class V_DetailFilm : Form
    {
        private static readonly string connectionString = "Host=localhost;Username=postgres;Password=1;Database=Bioskop;Port=5433";
        private int selectedFilmId;

        public V_DetailFilm(int filmId)
        {
            InitializeComponent();
            selectedFilmId = filmId;
            LoadFilmDetails(); // Memuat informasi film saat form dimuat
        }

        private void LoadFilmDetails()
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    // Mengambil data genre, sutradara, aktor, durasi, produksi, gambar, dan sinopsis berdasarkan film_id
                    string query = @"
                        SELECT genre, sutradara, aktor, durasi, produksi, gambar, sinopsis, judul_film 
                        FROM film 
                        WHERE film_id = @filmId"; // Menggunakan parameter untuk keamanan
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@filmId", selectedFilmId);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var customFont = new Font("Inter", 14, FontStyle.Regular);
                                // Mengisi label dengan data yang sesuai
                                lblGenre.Text = reader["genre"].ToString();
                                lblGenre.Font = customFont;

                                lblSutradara.Text = reader["sutradara"].ToString();
                                lblSutradara.Font = customFont;

                                lblCast.Text = reader["aktor"].ToString();
                                lblCast.Font = customFont;

                                lblDurasi.Text = reader["durasi"].ToString();
                                lblDurasi.Font = customFont;

                                lblProduksi.Text = reader["produksi"].ToString();
                                lblProduksi.Font = customFont;

                                lblSinopsis.Text = reader["sinopsis"].ToString();
                                lblSinopsis.Font = customFont;

                                lblJudulFilm.Text = reader["judul_film"].ToString();
                                lblJudulFilm.Font = new Font("Britannic Bold", 30, FontStyle.Bold);
                                lblJudulFilm.BackColor = Color.MistyRose;
                                //label7.Font = Color.White;

                                // Menampilkan gambar di PictureBox
                                if (reader["gambar"] != DBNull.Value)
                                {
                                    byte[] imageBytes = (byte[])reader["gambar"];
                                    using (var ms = new MemoryStream(imageBytes))
                                    {
                                        pbPosterFilm.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    pbPosterFilm.Image = null; // Tidak ada gambar
                                }
                            }
                            else
                            {
                                // Jika tidak ada data untuk film_id tertentu
                                lblGenre.Text = "Tidak ditemukan";
                                lblSutradara.Text = "Tidak ditemukan";
                                lblCast.Text = "Tidak ditemukan";
                                lblDurasi.Text = "Tidak ditemukan";
                                lblProduksi.Text = "Tidak ditemukan";
                                lblSinopsis.Text = "Tidak ditemukan";
                                lblJudulFilm.Text = "Judul Tidak Ditemukan";
                                pbPosterFilm.Image = null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Menampilkan pesan error jika ada masalah
                MessageBox.Show($"Terjadi kesalahan saat memuat detail film: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLanjut_Click(object sender, EventArgs e)
        {
            // Navigasi ke form detail berikutnya, misalnya form tambahan
            V_DetailFilm2 formDetailFilm2 = new V_DetailFilm2(selectedFilmId);
            formDetailFilm2.Show();
            this.Hide();
        }

        private void btLogout_Click_1(object sender, EventArgs e)
        {
            V_Login formLogin = new V_Login();
            formLogin.Show();
            this.Hide();
        }

        private void btRiwayat_Click_1(object sender, EventArgs e)
        {
            V_RiwayatPesanan formRiwayatPesanan = new V_RiwayatPesanan();
            formRiwayatPesanan.Show();
            this.Hide();
        }

        private void btProfil_Click(object sender, EventArgs e)
        {
            V_Profil formProfil = new V_Profil(); // Membuat instance dari form V_Profil
            formProfil.Show(); // Menampilkan form V_Profil
            // Menyembunyikan form saat ini (form yang berisi button btProfil)
            this.Hide();
        }
    }
}
