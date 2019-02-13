namespace UniversityManagementSystem.Data.Entities
{
    public class FactRental
    {
        public int UserId { get; set; }
        public DimUser User { get; set; }

        public int BookId { get; set; }
        public DimBook Book { get; set; }

        public int YearId { get; set; }
        public DimYear Year { get; set; }

        public int NoOfRentals { get; set; }
    }
}