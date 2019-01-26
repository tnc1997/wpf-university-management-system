using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Data.Entities.Dimensions
{
    [Table("W_COURSES_D")]
    public class Course
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public ICollection<Facts.Graduate> Graduates { get; set; }
        
        public ICollection<Facts.Student> Students { get; set; }
    }
}