using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class DimYear
    {
        public int Id { get; set; }

        public int Year { get; set; }

        public ICollection<FactAssignment> Assignments { get; set; }

        public ICollection<FactBook> Books { get; set; }

        public ICollection<FactGraduate> Graduates { get; set; }

        public ICollection<FactHall> Halls { get; set; }

        public ICollection<FactLecture> Lectures { get; set; }

        public ICollection<FactLibrary> Libraries { get; set; }

        public ICollection<FactModule> Modules { get; set; }

        public ICollection<FactRental> Rentals { get; set; }

        public ICollection<FactRoom> Rooms { get; set; }

        public ICollection<FactStudent> Students { get; set; }
    }
}