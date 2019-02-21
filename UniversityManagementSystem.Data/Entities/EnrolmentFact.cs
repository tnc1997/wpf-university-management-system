namespace UniversityManagementSystem.Data.Entities
{
    public class EnrolmentFact : FactBase
    {
        public int ModuleDimId { get; set; }
        public ModuleDim ModuleDim { get; set; }
    }
}