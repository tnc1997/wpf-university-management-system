namespace UniversityManagementSystem.Data.Entities
{
    public class FactBook
    {
        public int LibraryId { get; set; }
        public DimLibrary Library { get; set; }

        public int YearId { get; set; }
        public DimYear Year { get; set; }

        public int NoOfBooks { get; set; }
    }
}