using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Data.Entities.Facts
{
    [Table("W_STUDENTS_F")]
    public class Student
    {
        public int CampusId { get; set; }
        public Dimensions.Campus Campus { get; set; }
        
        public int CourseId { get; set; }
        public Dimensions.Course Course { get; set; }
        
        public int ModuleId { get; set; }
        public Dimensions.Module Module { get; set; }
        
        public int TimeId { get; set; }
        public Dimensions.Time Time { get; set; }
        
        public int NoOfStudents { get; set; }
    }
}