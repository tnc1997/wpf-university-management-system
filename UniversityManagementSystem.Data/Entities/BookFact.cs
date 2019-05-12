namespace UniversityManagementSystem.Data.Entities
{
    public class BookFact : FactBase
    {
        public int LibraryDimId { get; set; }
        public LibraryDim LibraryDim { get; set; }
    }
}