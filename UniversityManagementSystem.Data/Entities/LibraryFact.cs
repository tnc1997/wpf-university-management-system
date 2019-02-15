namespace UniversityManagementSystem.Data.Entities
{
    public class LibraryFact : FactBase
    {
        public int CampusDimId { get; set; }
        public CampusDim CampusDim { get; set; }
    }
}