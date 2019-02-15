namespace UniversityManagementSystem.Data.Entities
{
    public class LectureFact : FactBase
    {
        public int ModuleDimId { get; set; }
        public ModuleDim ModuleDim { get; set; }

        public int RoomDimId { get; set; }
        public RoomDim RoomDim { get; set; }
    }
}