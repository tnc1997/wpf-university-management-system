using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class YearDim
    {
        public int Id { get; set; }

        public int Year { get; set; }

        public ICollection<AssignmentFact> AssignmentFacts { get; set; }

        public ICollection<BookFact> BookFacts { get; set; }

        public ICollection<EnrolmentFact> EnrolmentFacts { get; set; }

        public ICollection<GraduationFact> GraduationFacts { get; set; }

        public ICollection<HallFact> HallFacts { get; set; }

        public ICollection<LectureFact> LectureFacts { get; set; }

        public ICollection<LibraryFact> LibraryFacts { get; set; }

        public ICollection<ModuleFact> ModuleFacts { get; set; }

        public ICollection<RentalFact> RentalFacts { get; set; }

        public ICollection<ResultFact> ResultFacts { get; set; }

        public ICollection<RoomFact> RoomFacts { get; set; }

        public ICollection<StudentFact> StudentFacts { get; set; }

        public override string ToString()
        {
            return Year.ToString();
        }
    }
}