namespace UniversityManagementSystem.Data.Entities
{
    public class Enrolment : EntityBase
    {
        public int Year { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int RunId { get; set; }
        public Run Run { get; set; }
    }
}