namespace UniversityManagementSystem.Data.Entities
{
    public class FactRoom
    {
        public int CampusId { get; set; }
        public DimCampus Campus { get; set; }

        public int YearId { get; set; }
        public DimYear Year { get; set; }

        public int NoOfRooms { get; set; }
    }
}