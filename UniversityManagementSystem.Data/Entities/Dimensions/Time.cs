using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Data.Entities.Dimensions
{
    [Table("W_TIMES_D")]
    public class Time
    {
        public int Id { get; set; }
        
        public int Year { get; set; }
        
        public ICollection<Facts.Graduate> Graduates { get; set; }
        
        public ICollection<Facts.Student> Students { get; set; }
    }
}