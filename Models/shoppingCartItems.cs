using System.ComponentModel.DataAnnotations;
namespace eTickets.Models
{
    public class shoppingCartItems
    {
        public int Id { get; set; }
        public Movie film { get; set; }

        public float amount { get; set; }

        public user bnda { get; set; }
        public List<Movie> CartItems { get; set; }
    }
}
