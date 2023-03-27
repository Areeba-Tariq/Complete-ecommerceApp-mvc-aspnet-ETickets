using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class user
    {
        [Key]
        public int Id { get; set; }
        public string  name { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        //relationships
        public List<downloadedMovies> downloadMovie { get; set; }
    }
}
