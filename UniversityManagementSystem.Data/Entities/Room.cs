using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class Room : EntityBase
    {
        public string Name { get; set; }

        public int CampusId { get; set; }
        public Campus Campus { get; set; }

        public ICollection<Lecture> Lectures { get; set; }
    }
}