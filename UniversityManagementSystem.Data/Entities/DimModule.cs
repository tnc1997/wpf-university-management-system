using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class DimModule
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Title { get; set; }

        public ICollection<FactAssignment> Assignments { get; set; }

        public ICollection<FactLecture> Lectures { get; set; }

        public ICollection<FactStudent> Students { get; set; }
    }
}