namespace UniversityManagementSystem.Data.Entities
{
    public class AssignmentFact : FactBase
    {
        public int ModuleDimId { get; set; }
        public ModuleDim ModuleDim { get; set; }
    }
}