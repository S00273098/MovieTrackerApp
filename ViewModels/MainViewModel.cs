using MovieTrackerApp.Commands;
using MovieTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTrackerApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _selectedTabIndex;
        public int SelectedTabIndex
        {
            get => _selectedTabIndex;
            set
            {
                _selectedTabIndex = value;
                OnPropertyChanged(nameof(SelectedTabIndex));
            }
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ObservableCollection<Movie> AllMovies { get; set; }
        public IEnumerable<Movie> WantToWatch => AllMovies.Where(m => m.Status == MovieStatus.WantToWatch);

        public IEnumerable<Movie> Watching => AllMovies.Where(m => m.Status == MovieStatus.Watching);

        public IEnumerable<Movie> Watched => AllMovies.Where(m => m.Status == MovieStatus.Watched);
        public RelayCommand SearchMovieCommand { get; set; }
        public MainViewModel()
        {
            AllMovies = new ObservableCollection<Movie>();
            SearchMovieCommand = new RelayCommand(async () => await SearchMovie());
        }
        private void SaveToDatabase(Movie movie)
        {
            using (var db = new AppDbContext())
            {
                db.Movies.Add(movie);
                db.SaveChanges();
            }
        }
        private readonly OmdbService _omdbService = new OmdbService();


        private string _searchText;
        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                OnPropertyChanged(nameof(SearchText));
            }
        }
        private async Task SearchMovie()
        {
            if (string.IsNullOrWhiteSpace(SearchText))
                return;

            var dto = await _omdbService.GetMovieAsync(SearchText);

            if (dto == null || dto.Title == null)
                return;

            var movie = MovieMapper.MapToMovie(dto);

            AllMovies.Add(movie);
            AllMovies.Add(new Movie { Title = "Inception", Genre = "Sci-Fi" });
            AllMovies.Add(new Movie { Title = "Interstellar", Genre = "Sci-Fi" });

            SaveToDatabase(movie);
        }
    }
}
