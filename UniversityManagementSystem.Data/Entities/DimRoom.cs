using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class DimRoom
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<FactLecture> Lectures { get; set; }
    }
}