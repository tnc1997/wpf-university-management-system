using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class DimCampus
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<FactHall> Halls { get; set; }

        public ICollection<FactLibrary> Libraries { get; set; }

        public ICollection<FactRoom> Rooms { get; set; }

        public ICollection<FactStudent> Students { get; set; }
    }
}