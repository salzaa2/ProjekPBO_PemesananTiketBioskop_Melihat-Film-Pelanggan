using core;
using Npgsql;
using ProjekPBO_PemesananTiketBioskop.App.Model;
using ProjekPBO_PemesananTiketBioskop.App.View;
using System;
using System.Data;

namespace ProjekPBO_PemesananTiketBioskop.App.Context
{
    internal class C_detailFilm
    {
        private static readonly string connectionString = "Host=localhost;Username=postgres;Password=1;Database=Bioskop;Port=5433";

        private static string table = "detail_film";

        // Method untuk menambah detail film
        // Method untuk menambah detail film
        public static void AddDetailFilm(M_DetailFilm dataFilm)
        {
            string query = $"INSERT INTO {table}(ruangan_id, film_id) VALUES(@ruangan_id, @film_id);";

            NpgsqlParameter[] parameters =
            {
        new NpgsqlParameter("@ruangan_id", dataFilm.ruangan_id),
        new NpgsqlParameter("@film_id", dataFilm.film_id),
    };

            // Menggunakan NpgsqlCommand untuk mengeksekusi query
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddRange(parameters);
                        command.ExecuteNonQuery(); // Menjalankan query
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing AddDetailFilm: " + ex.Message);
            }
        }

        // Method untuk memperbarui detail film
        public static void UpdateDetailFilm(M_DetailFilm dataFilm)
        {
            string query = $"UPDATE {table} SET ruangan_id = @ruangan_id WHERE film_id = @film_id;";

            NpgsqlParameter[] parameters =
            {
        new NpgsqlParameter("@ruangan_id", dataFilm.ruangan_id),
        new NpgsqlParameter("@film_id", dataFilm.film_id),
    };

            // Menggunakan NpgsqlCommand untuk mengeksekusi query
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddRange(parameters);
                        command.ExecuteNonQuery(); // Menjalankan query
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing UpdateDetailFilm: " + ex.Message);
            }
        }


        // Method untuk mengambil detail film berdasarkan filmId
        public static M_Film GetFilmDetails(int filmId)
        {
            M_Film filmDetails = new M_Film();

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT genre, sutradara, aktor, durasi, produksi, gambar, sinopsis, judul_film 
                        FROM film 
                        WHERE film_id = @filmId";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@filmId", filmId);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                filmDetails.genre = reader["genre"].ToString();
                                filmDetails.sutradara = reader["sutradara"].ToString();
                                filmDetails.aktor = reader["aktor"].ToString();
                                filmDetails.durasi = reader["durasi"].ToString();
                                filmDetails.produksi = reader["produksi"].ToString();
                                filmDetails.sinopsis = reader["sinopsis"].ToString();
                                filmDetails.judul_film = reader["judul_film"].ToString();
                                filmDetails.gambar = reader["gambar"] as byte[]; // Jika gambar ada, simpan dalam byte array
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching film details: " + ex.Message);
            }

            return filmDetails;
        }
    }
}

