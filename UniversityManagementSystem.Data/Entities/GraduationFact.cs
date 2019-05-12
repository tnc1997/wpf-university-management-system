namespace UniversityManagementSystem.Data.Entities
{
    public class GraduationFact : FactBase
    {
        public int CourseDimId { get; set; }
        public CourseDim CourseDim { get; set; }
    }
}