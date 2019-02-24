using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class RoomDim
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<LectureFact> LectureFacts { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}