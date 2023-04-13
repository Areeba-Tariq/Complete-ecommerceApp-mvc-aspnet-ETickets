using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class downloadedMovies
    {
        [Key]
        public int id { get; set; } 
        public Movie Movie { get; set; }
        public user user { get; set; }

        public List<Movie> downloadMovie { get; set; }
    }
}
