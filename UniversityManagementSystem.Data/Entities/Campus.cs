using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class Campus : EntityBase
    {
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }

        public ICollection<Hall> Halls { get; set; }

        public ICollection<Library> Libraries { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}