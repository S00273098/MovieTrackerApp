using System.Windows.Input;
using MovieTrackerApp.Models;

public static class MovieMapper
{
    public static Movie MapToMovie(OmdbMovieDto dto)
    {
        return new Movie
        {
            Title = dto.Title,
            Genre = dto.Genre,
            ImagePath = dto.Poster,
            Status = MovieStatus.WantToWatch
        };
    }
}