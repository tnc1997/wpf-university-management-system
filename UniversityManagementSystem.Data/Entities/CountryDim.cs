using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class CountryDim
    {
        public int Id { get; set; }

        public string Country { get; set; }

        public ICollection<StudentFact> StudentFacts { get; set; }

        public override string ToString()
        {
            return Country;
        }
    }
}