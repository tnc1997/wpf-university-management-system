namespace UniversityManagementSystem.Data.Entities
{
    public class FactBase : IFact
    {
        public int YearDimId { get; set; }
        public YearDim YearDim { get; set; }
        
        public int Count { get; set; }
    }
}