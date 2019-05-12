namespace UniversityManagementSystem.Data.Entities
{
    public class RentalFact : FactBase
    {
        public int UserDimId { get; set; }
        public UserDim UserDim { get; set; }

        public int BookDimId { get; set; }
        public BookDim BookDim { get; set; }
    }
}