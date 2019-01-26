namespace UniversityManagementSystem.Data.Entities
{
    public class Result : EntityBase
    {
        public int Grade { get; set; }

        public string Feedback { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }
    }
}