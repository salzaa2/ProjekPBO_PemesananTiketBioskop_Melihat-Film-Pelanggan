using core;
using Npgsql;
using ProjekPBO_PemesananTiketBioskop.App.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace ProjekPBO_PemesananTiketBioskop.App.Context
{
    internal class C_film : DatabaseWrapper
    {
        private static string table = "film";

        // Fetch all films from the 'film' table
        public static DataTable All()
        {
            string query = $"SELECT * FROM {table}";
            return queryExecutor(query);
        }

        // Add a new film into the 'film' table
        public static int AddDataFilm(M_Film dataFilm)
        {
            string query = $@"
                INSERT INTO {table} (
                    judul_film, genre, sutradara, produksi, aktor, batas_umur, durasi, sinopsis, harga, gambar, status, waktu_tayang, tanggal_tayang
                ) VALUES (
                    @judul_film, @genre, @sutradara, @produksi, @aktor, @batas_umur, @durasi, @sinopsis, @harga, @gambar, @status, @waktu_tayang, @tanggal_tayang
                ) RETURNING film_id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@judul_film", dataFilm.judul_film),
                new NpgsqlParameter("@genre", dataFilm.genre),
                new NpgsqlParameter("@sutradara", dataFilm.sutradara),
                new NpgsqlParameter("@produksi", dataFilm.produksi),
                new NpgsqlParameter("@aktor", dataFilm.aktor),
                new NpgsqlParameter("@batas_umur", dataFilm.batas_umur),
                new NpgsqlParameter("@durasi", dataFilm.durasi),
                new NpgsqlParameter("@sinopsis", string.IsNullOrWhiteSpace(dataFilm.sinopsis) ? (object)DBNull.Value : dataFilm.sinopsis),
                new NpgsqlParameter("@harga", dataFilm.harga),
                new NpgsqlParameter("@gambar", dataFilm.gambar),
                new NpgsqlParameter("@status", dataFilm.status),
                new NpgsqlParameter("@waktu_tayang", dataFilm.waktuTayang),
                new NpgsqlParameter("@tanggal_tayang", dataFilm.tanggalTayang)
            };

            var result = ExecuteScalarCommand(query, parameters);
            return result != null && int.TryParse(result.ToString(), out int filmId) ? filmId : 0;
        }

        // Update an existing film's details
        public static void UpdateFilm(M_Film dataFilm)
        {
            string query = $@"
                UPDATE {table}
                SET 
                    judul_film = @judul_film,
                    genre = @genre, 
                    sutradara = @sutradara, 
                    produksi = @produksi, 
                    aktor = @aktor, 
                    batas_umur = @batas_umur, 
                    durasi = @durasi, 
                    sinopsis = @sinopsis, 
                    harga = @harga, 
                    gambar = @gambar, 
                    status = @status, 
                    waktu_tayang = @waktu_tayang, 
                    tanggal_tayang = @tanggal_tayang
                WHERE film_id = @film_id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@judul_film", dataFilm.judul_film),
                new NpgsqlParameter("@genre", dataFilm.genre),
                new NpgsqlParameter("@sutradara", dataFilm.sutradara),
                new NpgsqlParameter("@produksi", dataFilm.produksi),
                new NpgsqlParameter("@aktor", dataFilm.aktor),
                new NpgsqlParameter("@batas_umur", dataFilm.batas_umur),
                new NpgsqlParameter("@durasi", dataFilm.durasi),
                new NpgsqlParameter("@sinopsis", string.IsNullOrWhiteSpace(dataFilm.sinopsis) ? (object)DBNull.Value : dataFilm.sinopsis),
                new NpgsqlParameter("@harga", dataFilm.harga),
                new NpgsqlParameter("@gambar", dataFilm.gambar),
                new NpgsqlParameter("@status", dataFilm.status),
                new NpgsqlParameter("@waktu_tayang", dataFilm.waktuTayang),
                new NpgsqlParameter("@tanggal_tayang", dataFilm.tanggalTayang),
                new NpgsqlParameter("@film_id", dataFilm.film_id)
            };

            commandExecutor(query, parameters);
        }

        // Fetch a film by its ID along with its details
        public static M_Film GetFilmById(int filmId)
        {
            string query = $@"
                SELECT * FROM {table} 
                WHERE film_id = @film_id";
            NpgsqlParameter[] parameters = { new NpgsqlParameter("@film_id", filmId) };

            DataTable data = queryExecutor(query, parameters);
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                return new M_Film
                {
                    film_id = Convert.ToInt32(row["film_id"]),
                    judul_film = row["judul_film"].ToString(),
                    genre = row["genre"].ToString(),
                    sutradara = row["sutradara"].ToString(),
                    produksi = row["produksi"].ToString(),
                    aktor = row["aktor"].ToString(),
                    batas_umur = Convert.ToInt32(row["batas_umur"]),
                    durasi = row["durasi"].ToString(),
                    sinopsis = row["sinopsis"] == DBNull.Value ? null : row["sinopsis"].ToString(),
                    harga = Convert.ToInt32(row["harga"]),
                    gambar = row["gambar"] == DBNull.Value ? null : (byte[])row["gambar"],
                    status = row["status"].ToString(),
                    waktuTayang = (TimeSpan)row["waktu_tayang"],
                    tanggalTayang = (DateTime)row["tanggal_tayang"]
                };
            }
            return null; // Film not found
        }

        // Fetch films by user-defined filters (e.g., by age limit)
        public static List<M_Film> GetFilmsByFilter(string usiaFilter)
        {
            string query = usiaFilter.ToLower() switch
            {
                "13+" => $"SELECT * FROM {table} WHERE batas_umur >= 13",
                "17+" => $"SELECT * FROM {table} WHERE batas_umur >= 17",
                _ => $"SELECT * FROM {table}" // Default: select all films
            };

            DataTable data = queryExecutor(query);
            List<M_Film> filmList = new List<M_Film>();

            foreach (DataRow row in data.Rows)
            {
                filmList.Add(new M_Film
                {
                    film_id = Convert.ToInt32(row["film_id"]),
                    judul_film = row["judul_film"].ToString(),
                    genre = row["genre"].ToString(),
                    sutradara = row["sutradara"].ToString(),
                    produksi = row["produksi"].ToString(),
                    aktor = row["aktor"].ToString(),
                    batas_umur = Convert.ToInt32(row["batas_umur"]),
                    durasi = row["durasi"].ToString(),
                    sinopsis = row["sinopsis"] == DBNull.Value ? null : row["sinopsis"].ToString(),
                    harga = Convert.ToInt32(row["harga"]),
                    gambar = row["gambar"] == DBNull.Value ? null : (byte[])row["gambar"],
                    status = row["status"].ToString(),
                    waktuTayang = (TimeSpan)row["waktu_tayang"],
                    tanggalTayang = (DateTime)row["tanggal_tayang"]
                });
            }

            return filmList;
        }

        // Fetch data combining 'film' and 'detail_film' tables
        //public static DataTable GetFilmDetails()
        //{
        //    string query = @"
        //        SELECT  
        //            film.film_id,
        //            film.judul_film, 
        //            film.genre, 
        //            film.sutradara, 
        //            film.produksi, 
        //            film.aktor, 
        //            film.batas_umur, 
        //            film.durasi, 
        //            film.sinopsis, 
        //            film.harga, 
        //            film.status,
        //            ruangan.nama_ruangan
        //        FROM 
        //            detail_film
        //        JOIN 
        //            film ON detail_film.film_id = film.film_id
        //        JOIN 
        //            ruangan ON detail_film.ruangan_id = ruangan.ruangan_id;
        //        ";

        //    return queryExecutor(query);
        //}

        public static DataTable GetDataFilm()
        {
            string query = @"
                SELECT  
                    film.film_id,
                    film.judul_film, 
                    film.genre, 
                    film.sutradara, 
                    film.produksi, 
                    film.aktor, 
                    film.batas_umur, 
                    film.durasi, 
                    film.sinopsis, 
                    film.harga, 
                    film.status,
                    ruangan.nama_ruangan
                FROM 
                    detail_film
                JOIN 
                    film ON detail_film.film_id = film.film_id
                JOIN 
                    ruangan ON detail_film.ruangan_id = ruangan.ruangan_id;
                 ";

            return queryExecutor(query);
        }
    }
}
