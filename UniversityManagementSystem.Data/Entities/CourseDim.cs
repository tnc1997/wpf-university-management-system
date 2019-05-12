using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class CourseDim
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<GraduationFact> GraduationFacts { get; set; }

        public ICollection<ModuleFact> ModuleFacts { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}