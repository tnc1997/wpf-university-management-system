namespace UniversityManagementSystem.Data.Entities
{
    public class Graduation : EntityBase
    {
        public int Year { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}