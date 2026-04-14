using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTrackerApp.Models
{
    public enum MovieStatus
    {
        WantToWatch,
        Watching,
        Watched
    }

    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public MovieStatus Status { get; set; }

        public string ImagePath { get; set; }

        public int Rating { get; set; } 
    }
}
