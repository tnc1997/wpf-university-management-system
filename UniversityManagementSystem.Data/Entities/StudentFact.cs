namespace UniversityManagementSystem.Data.Entities
{
    public class StudentFact : FactBase
    {
        public int CountryDimId { get; set; }
        public CountryDim CountryDim { get; set; }
    }
}