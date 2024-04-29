namespace MoviesApp.Model
{
    public class MoviesList
    {
        public int Page { get; set; }
        public List<Movie> Results { get; set; } = new();
        public int Total_pages { get; set; }
        public int Total_results { get; set; }
    }
}
