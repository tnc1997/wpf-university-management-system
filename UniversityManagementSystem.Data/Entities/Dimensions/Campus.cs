using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Data.Entities.Dimensions
{
    [Table("W_CAMPUSES_D")]
    public class Campus
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public ICollection<Facts.Room> Rooms { get; set; }
        
        public ICollection<Facts.Hall> Halls { get; set; }
        
        public ICollection<Facts.Library> Libraries { get; set; }
        
        public ICollection<Facts.Student> Students { get; set; }
    }
}