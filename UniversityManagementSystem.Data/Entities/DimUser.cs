using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class DimUser
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<FactRental> Rentals { get; set; }
    }
}