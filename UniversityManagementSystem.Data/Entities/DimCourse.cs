using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class DimCourse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<FactGraduate> Graduates { get; set; }

        public ICollection<FactModule> Modules { get; set; }
    }
}