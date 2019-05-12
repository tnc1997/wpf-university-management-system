namespace UniversityManagementSystem.Data.Entities
{
    public class RoomFact : FactBase
    {
        public int CampusDimId { get; set; }
        public CampusDim CampusDim { get; set; }
    }
}