﻿namespace MoviesApp.Model
{
    public class Movie
    {
        public bool Adult { get; set; }
        public string Backdrop_path { get; set; } = string.Empty;
        public List<int> Genre_ids { get; set; } = null!;
        public int Id { get; set; }
        public string Original_language { get; set; } = string.Empty;
        public string Original_title { get; set; } = string.Empty;
        public string Overview { get; set; } = string.Empty;
        public double Popularity { get; set; }
        public string Poster_path { get; set; } = string.Empty;
        public string Release_date { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public bool Video { get; set; }
        public double Vote_average { get; set; }
        public int Vote_count { get; set; }
    }
}
