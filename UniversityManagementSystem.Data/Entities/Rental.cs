using System;

namespace UniversityManagementSystem.Data.Entities
{
    public class Rental : EntityBase
    {
        public DateTime CheckoutDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}