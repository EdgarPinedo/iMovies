namespace MoviesApp.Model
{
    public class MovieImages
    {
        public List<Backdrop>? Backdrops { get; set; }
        public int Id { get; set; }
        public List<Logo>? Logos { get; set; }
        public List<Poster>? Posters { get; set; }
    }

    public class Backdrop
    {
        public double Aspect_ratio { get; set; }
        public int Height { get; set; }
        public string? Iso_639_1 { get; set; }
        public string? File_path { get; set; }
        public double Vote_average { get; set; }
        public int Vote_count { get; set; }
        public int Width { get; set; }
    }

    public class Logo
    {
        public double Aspect_ratio { get; set; }
        public int Height { get; set; }
        public string? Iso_639_1 { get; set; }
        public string? File_path { get; set; }
        public double Vote_average { get; set; }
        public int Vote_count { get; set; }
        public int Width { get; set; }
    }

    public class Poster
    {
        public double Aspect_ratio { get; set; }
        public int Height { get; set; }
        public string? Iso_639_1 { get; set; }
        public string? File_path { get; set; }
        public double Vote_average { get; set; }
        public int Vote_count { get; set; }
        public int Width { get; set; }
    }
}
