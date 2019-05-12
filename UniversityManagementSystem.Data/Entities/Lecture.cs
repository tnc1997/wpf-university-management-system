using System;

namespace UniversityManagementSystem.Data.Entities
{
    public class Lecture : EntityBase
    {
        public DateTime DateTime { get; set; }

        public int Duration { get; set; }

        public int RunId { get; set; }
        public Run Run { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}