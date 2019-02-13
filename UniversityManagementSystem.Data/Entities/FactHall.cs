namespace UniversityManagementSystem.Data.Entities
{
    public class FactHall
    {
        public int CampusId { get; set; }
        public DimCampus Campus { get; set; }

        public int YearId { get; set; }
        public DimYear Year { get; set; }

        public int NoOfHalls { get; set; }
    }
}