namespace UniversityManagementSystem.Data.Entities
{
    public class FactLecture
    {
        public int ModuleId { get; set; }
        public DimModule Module { get; set; }

        public int RoomId { get; set; }
        public DimRoom Room { get; set; }

        public int YearId { get; set; }
        public DimYear Year { get; set; }

        public int NoOfLectures { get; set; }
    }
}