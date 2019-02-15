namespace UniversityManagementSystem.Data.Entities
{
    public class StudentFact : FactBase
    {
        public int ModuleDimId { get; set; }
        public ModuleDim ModuleDim { get; set; }

        public int ClassificationDimId { get; set; }
        public ClassificationDim ClassificationDim { get; set; }
    }
}