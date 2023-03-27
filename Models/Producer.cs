using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }


        //relationships
        public List<Movie> Movies { get; set; } 
    }
}
