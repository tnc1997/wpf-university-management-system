using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class ModuleDim
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Title { get; set; }

        public ICollection<AssignmentFact> AssignmentFacts { get; set; }

        public ICollection<EnrolmentFact> EnrolmentFacts { get; set; }

        public ICollection<LectureFact> LectureFacts { get; set; }

        public ICollection<ResultFact> ResultFacts { get; set; }

        public override string ToString()
        {
            return $"{Code} - {Title}";
        }
    }
}