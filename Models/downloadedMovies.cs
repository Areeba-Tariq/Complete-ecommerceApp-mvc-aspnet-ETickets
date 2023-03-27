namespace eTickets.Models
{
    public class downloadedMovies
    {
        public Movie Movie { get; set; }
        public user user { get; set; }

        public List<Movie> downloadMovie { get; set; }
    }
}
