using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class CampusDim
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<HallFact> HallFacts { get; set; }

        public ICollection<LibraryFact> LibraryFacts { get; set; }

        public ICollection<RoomFact> RoomFacts { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}