using MoviesApp.Model;

namespace MoviesApp.Data
{
    public class MoviesService
    {
        private readonly HttpClient _http;

        public MoviesService(HttpClient http) 
            => _http = http;

        public async Task<MoviesList?> GetUpComingMovies()
            => await _http.GetFromJsonAsync<MoviesList>("movie/upcoming?language=es-MX&page=1");
        
        public async Task<MoviesList?> GetPopularMovies() 
            => await _http.GetFromJsonAsync<MoviesList>("movie/popular?language=es-MX&page=1");

        public async Task<MoviesList?> GetTopRatedMovies()
            => await _http.GetFromJsonAsync<MoviesList>("movie/top_rated?language=es-MX&page=1");

        public async Task<GenresList?> GetMovieGenres()
            => await _http.GetFromJsonAsync<GenresList>("genre/movie/list?language=es-MX");

        public async Task<MovieImages?> GetMovieImages(int id)
            => await _http.GetFromJsonAsync<MovieImages>($"movie/{id}/images?include_image_language=es");

        public async Task<Detail?> GetDetails(int id)
            => await _http.GetFromJsonAsync<Detail>($"movie/{id}?append_to_response=videos&language=es-MX");

        public async Task<CastList?> GetCast(int id)
            => await _http.GetFromJsonAsync<CastList>($"movie/{id}/credits?language=es-MX");

        public async Task<MoviesList?> GetSimilarMovies(int id)
            => await _http.GetFromJsonAsync<MoviesList>($"movie/{id}/similar?language=es-MX&page=1");

        public async Task<MoviesList?> SearchMovie(string query, int page)
            => await _http.GetFromJsonAsync<MoviesList>($"search/movie?query={query}&include_adult=false&language=es-MX&page={page}");

        public async Task<MoviesList?> GetMoviesByGenre(string genre, int page)
            => await _http.GetFromJsonAsync<MoviesList>($"discover/movie?include_adult=false&include_video=false&language=es-MX&page={page}&sort_by=popularity.desc&with_genres={genre}");
    }
}
