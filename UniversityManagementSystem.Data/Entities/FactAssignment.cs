namespace UniversityManagementSystem.Data.Entities
{
    public class FactAssignment
    {
        public int ModuleId { get; set; }
        public DimModule Module { get; set; }

        public int YearId { get; set; }
        public DimYear Year { get; set; }

        public int NoOfAssignments { get; set; }
    }
}