namespace UniversityManagementSystem.Data.Entities
{
    public class ModuleFact : FactBase
    {
        public int CourseDimId { get; set; }
        public CourseDim CourseDim { get; set; }
    }
}