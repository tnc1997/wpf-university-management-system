using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class BookDim
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public ICollection<RentalFact> RentalFacts { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Author}";
        }
    }
}