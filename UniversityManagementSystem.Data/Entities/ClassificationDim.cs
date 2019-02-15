using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class ClassificationDim
    {
        public int Id { get; set; }

        public string Classification { get; set; }

        public ICollection<StudentFact> StudentFacts { get; set; }
    }
}