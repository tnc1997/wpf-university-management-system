using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class DimLibrary
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<FactBook> Books { get; set; }
    }
}