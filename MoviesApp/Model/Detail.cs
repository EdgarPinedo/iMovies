namespace MoviesApp.Model
{
    public class Detail
    {
        public bool Adult { get; set; }
        public string Backdrop_path { get; set; } = string.Empty;
        public BelongsToCollection? Belongs_to_collection { get; set; }
        public int Budget { get; set; }
        public List<Genre>? Genres { get; set; }
        public string Homepage { get; set; } = string.Empty;
        public int Id { get; set; }
        public string Imdb_id { get; set; } = string.Empty;
        public string Original_language { get; set; } = string.Empty;
        public string Original_title { get; set; } = string.Empty;
        public string Overview { get; set; } = string.Empty;
        public double Popularity { get; set; }
        public string Poster_path { get; set; } = string.Empty;
        public List<ProductionCompany>? Production_companies { get; set; }
        public List<ProductionCountry>? Production_countries { get; set; }
        public string Release_date { get; set; } = string.Empty;
        public double Revenue { get; set; }
        public int Runtime { get; set; }
        public List<SpokenLanguage>? Spoken_languages { get; set; }
        public string Status { get; set; } = string.Empty;
        public string Tagline { get; set; } = string.Empty; 
        public string Title { get; set; } = string.Empty;   
        public bool Video { get; set; }
        public double Vote_average { get; set; }
        public int Vote_count { get; set; }
        public Videos? Videos { get; set; }
    }

    public class BelongsToCollection
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Poster_path { get; set; } = string.Empty;
        public string Backdrop_path { get; set; } = string.Empty;
    }

    public class ProductionCompany
    {
        public int Id { get; set; }
        public string Logo_path { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Origin_country { get; set; } = string.Empty;
    }

    public class ProductionCountry
    {
        public string Iso_3166_1 { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }

    public class Result
    {
        public string Iso_639_1 { get; set; } = string.Empty;
        public string Iso_3166_1 { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
        public string Site { get; set; } = string.Empty;
        public int Size { get; set; }
        public string Type { get; set; } = string.Empty;
        public bool Official { get; set; }
        public DateTime Published_at { get; set; }
        public string Id { get; set; } = string.Empty;
    }

    public class SpokenLanguage
    {
        public string English_name { get; set; } = string.Empty;
        public string Iso_639_1 { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }

    public class Videos
    {
        public List<Result>? Results { get; set; }
    }
}
