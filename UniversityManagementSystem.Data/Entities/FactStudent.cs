namespace UniversityManagementSystem.Data.Entities
{
    public class FactStudent
    {
        public int ModuleId { get; set; }
        public DimModule Module { get; set; }

        public int ClassificationId { get; set; }
        public DimClassification Classification { get; set; }

        public int YearId { get; set; }
        public DimYear Year { get; set; }

        public int NoOfStudents { get; set; }
    }
}