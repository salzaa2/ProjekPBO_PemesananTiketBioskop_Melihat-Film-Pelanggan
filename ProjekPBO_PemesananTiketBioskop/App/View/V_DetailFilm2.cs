using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Npgsql;

namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    public partial class V_DetailFilm2 : Form
    {
        private static readonly string connectionString = "Host=localhost;Username=postgres;Password=1;Database=Bioskop;Port=5433";
        private int selectedFilmId;

        // Constructor to initialize the form with the selected film ID
        public V_DetailFilm2(int filmId)
        {
            InitializeComponent();
            selectedFilmId = filmId;
            LoadFilmDetails();  // Load the film details when the form is initialized
        }

        // Function to load film details based on film_id
        private void LoadFilmDetails()
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    // Query to fetch price and image for the selected film
                    string query = "SELECT judul_film, harga, gambar FROM film WHERE film_id = @filmId";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@filmId", selectedFilmId);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Display the price in lblHarga
                                lblHarga.Text = "Harga: " + reader["harga"].ToString();

                                // Set the title of the film in lblJudulFilm
                                lblJudulFilm.Text = reader["judul_film"].ToString();
                                lblJudulFilm.Font = new Font("Britannic Bold", 30, FontStyle.Bold);
                                lblJudulFilm.BackColor = Color.MistyRose;

                                // Display the image in pictureBox1
                                if (reader["gambar"] != DBNull.Value)
                                {
                                    byte[] imageBytes = (byte[])reader["gambar"];
                                    using (var ms = new MemoryStream(imageBytes))
                                    {
                                        pictureBox1.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    pictureBox1.Image = null; // If no image, set the PictureBox to null
                                }
                            }
                            else
                            {
                                lblHarga.Text = "Harga tidak ditemukan!";
                                pictureBox1.Image = null; // If no image data found, clear the PictureBox
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat detail film: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Navigate to V_buatPesanan form when btLanjut is clicked
        private void btLanjut_Click(object sender, EventArgs e)
        {
            V_buatPesanan formBuatPesanan = new V_buatPesanan();
            formBuatPesanan.Show();
            this.Hide();
        }

        private void btProfil_Click(object sender, EventArgs e)
        {
            V_Profil formProfil = new V_Profil();
            formProfil.Show();
            this.Hide();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            V_Login formLogin = new V_Login();
            formLogin.Show();
            this.Hide();
        }

        private void btRiwayatPesanan_Click(object sender, EventArgs e)
        {
            V_RiwayatPesanan formRiwayatPesanan = new V_RiwayatPesanan();
            formRiwayatPesanan.Show();
            this.Hide();
        }
    }
}
