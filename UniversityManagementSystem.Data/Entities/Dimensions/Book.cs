using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Data.Entities.Dimensions
{
    [Table("W_BOOKS_D")]
    public class Book
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Author { get; set; }
        
        public ICollection<Facts.Rental> Rentals { get; set; }
    }
}