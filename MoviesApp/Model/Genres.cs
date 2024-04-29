namespace MoviesApp.Model
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }

    public class GenresList
    {
        public List<Genre> Genres { get; set; } = new();
    }
}
