namespace UniversityManagementSystem.Data.Entities
{
    public class CourseModule
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int ModuleId { get; set; }
        public Module Module { get; set; }
    }
}