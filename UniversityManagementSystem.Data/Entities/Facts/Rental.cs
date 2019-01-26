using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Data.Entities.Facts
{
    [Table("W_RENTALS_F")]
    public class Rental
    {
        public int BookId { get; set; }
        public Dimensions.Book Book { get; set; }
        
        public int NoOfRentals { get; set; }
    }
}