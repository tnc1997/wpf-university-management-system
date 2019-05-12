using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class Book : EntityBase
    {
        public string Name { get; set; }

        public string Author { get; set; }

        public ICollection<LibraryBook> LibraryBooks { get; set; }

        public ICollection<Rental> Rentals { get; set; }
    }
}