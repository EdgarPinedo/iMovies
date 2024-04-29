using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using MoviesApp.Model;
using System.Text.Json;

namespace MoviesApp.Data
{
    public class StorageService
    {
        private readonly ProtectedLocalStorage _localStorage;

        public StorageService(ProtectedLocalStorage localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task Add(string key, Movie movie)
        {
            try
            {
                var result = await _localStorage.GetAsync<List<Movie>>(key);
                if (result.Success)
                {
                    if(!result.Value!.Any(m => m.Id == movie.Id))
                    {
                        result.Value!.Add(movie);
                        await _localStorage.SetAsync(key, result.Value);
                    }
                }
                else
                {
                    List<Movie> movies = new() { movie };
                    await _localStorage.SetAsync(key, movies);
                }
            }
            catch (Exception) { }
        }

        public async Task Set(string key, List<Movie> movies)
        {
            await _localStorage.SetAsync(key, movies);
        }

        public async Task<List<Movie>?> Get(string key)
        {
            try
            {
                var result = await _localStorage.GetAsync<List<Movie>>(key);
                if (result.Success)
                {
                    return result.Value!;
                }
            }
            catch (Exception) { }
            return null;
        }

        public async Task<Dictionary<int, bool>> CreateDictionary(string key)
        {
            Dictionary<int, bool> dict = new();
            var result = await _localStorage.GetAsync<List<Movie>>(key);
            
            if (result.Success)
            {
                foreach (var movie in result.Value!)
                {
                    dict.Add(movie.Id, true);
                }
            }

            return dict;
        }

        public async Task Remove(string key, int id)
        {
            try
            {
                var result = await _localStorage.GetAsync<List<Movie>>(key);
                if (result.Success)
                {
                    result.Value!.RemoveAll(r => r.Id == id);
                    await _localStorage.SetAsync(key, result.Value);
                }
            }
            catch (Exception) { }
        }





        public async Task AddSearchQuery(string query)
        {
            try
            {
                var result = await _localStorage.GetAsync<List<string>>("Search");
                if (result.Success)
                {
                    if (!result.Value!.Any(m => m == query))
                    {
                        result.Value!.Add(query);
                        await _localStorage.SetAsync("Search", result.Value);
                    }
                }
                else
                {
                    List<string> list = new() { query };
                    await _localStorage.SetAsync("Search", list);
                }
            }
            catch (Exception) { }
        }

        public async Task<List<string>> GetSearchQuerys()
        {
            try
            {
                var result = await _localStorage.GetAsync<List<string>>("Search");
                if (result.Success)
                {
                    return result.Value!;
                }
            }
            catch (Exception) { }
            return new List<string>();
        }

        public async Task RemoveSearchQuery(string query)
        {
            try
            {
                var result = await _localStorage.GetAsync<List<string>>("Search");
                if (result.Success)
                {
                    result.Value!.RemoveAll(r => r == query);
                    await _localStorage.SetAsync("Search", result.Value);
                }
            }
            catch (Exception) { }
        }
    }
}
