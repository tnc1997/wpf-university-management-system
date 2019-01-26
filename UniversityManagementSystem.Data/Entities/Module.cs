using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class Module : EntityBase
    {
        public string Code { get; set; }

        public string Title { get; set; }

        public ICollection<CourseModule> CourseModules { get; set; }

        public ICollection<Run> Runs { get; set; }
    }
}