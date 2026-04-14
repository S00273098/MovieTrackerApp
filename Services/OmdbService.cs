using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class OmdbService
{
    private readonly HttpClient _httpClient = new HttpClient();
    private const string API_KEY = "240b88";

    public async Task<OmdbMovieDto> GetMovieAsync(string title)
    {
        var url = $"http://www.omdbapi.com/?t={title}&apikey={API_KEY}";

        var response = await _httpClient.GetStringAsync(url);

        return JsonSerializer.Deserialize<OmdbMovieDto>(response);
    }
}
