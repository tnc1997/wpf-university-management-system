using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class LibraryDim
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<BookFact> BookFacts { get; set; }
    }
}