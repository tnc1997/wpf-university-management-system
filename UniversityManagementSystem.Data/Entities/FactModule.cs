namespace UniversityManagementSystem.Data.Entities
{
    public class FactModule
    {
        public int CourseId { get; set; }
        public DimCourse Course { get; set; }

        public int YearId { get; set; }
        public DimYear Year { get; set; }

        public int NoOfModules { get; set; }
    }
}