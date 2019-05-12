namespace UniversityManagementSystem.Data.Entities
{
    public interface IFact
    {
        int YearDimId { get; set; }
        YearDim YearDim { get; set; }
        
        int Count { get; set; }
    }
}