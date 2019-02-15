using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class UserDim
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<RentalFact> RentalFacts { get; set; }
    }
}