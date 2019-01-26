using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Data.Entities.Facts
{
    [Table("W_GRADUATES_F")]
    public class Graduate
    {
        public int CourseId { get; set; }
        public Dimensions.Course Course { get; set; }
        
        public int TimeId { get; set; }
        public Dimensions.Time Time { get; set; }
        
        public int NoOfGraduates { get; set; }
    }
}