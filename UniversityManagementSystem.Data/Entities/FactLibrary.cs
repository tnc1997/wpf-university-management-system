namespace UniversityManagementSystem.Data.Entities
{
    public class FactLibrary
    {
        public int CampusId { get; set; }
        public DimCampus Campus { get; set; }

        public int YearId { get; set; }
        public DimYear Year { get; set; }

        public int NoOfLibraries { get; set; }
    }
}