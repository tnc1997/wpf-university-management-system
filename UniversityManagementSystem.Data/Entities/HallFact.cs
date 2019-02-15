namespace UniversityManagementSystem.Data.Entities
{
    public class HallFact : FactBase
    {
        public int CampusDimId { get; set; }
        public CampusDim CampusDim { get; set; }
    }
}