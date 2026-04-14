using System.Text.Json.Serialization;

public class OmdbMovieDto
{
    [JsonPropertyName("Title")]
    public string Title { get; set; }

    [JsonPropertyName("Year")]
    public string Year { get; set; }

    [JsonPropertyName("Genre")]
    public string Genre { get; set; }

    [JsonPropertyName("Poster")]
    public string Poster { get; set; }
}
