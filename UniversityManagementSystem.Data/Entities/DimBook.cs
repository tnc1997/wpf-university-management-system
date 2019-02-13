using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class DimBook
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public ICollection<FactRental> Rentals { get; set; }
    }
}