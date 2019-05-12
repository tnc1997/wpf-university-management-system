using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class User : EntityBase
    {
        public string UserName { get; set; }

        public string PasswordHash { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public ICollection<Enrolment> Enrolments { get; set; }

        public ICollection<Graduation> Graduations { get; set; }

        public ICollection<Rental> Rentals { get; set; }

        public ICollection<Result> Results { get; set; }
        
        public ICollection<UserRole> UserRoles { get; set; }
    }
}