using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class Run : EntityBase
    {
        public int Year { get; set; }

        public string Semester { get; set; }

        public int ModuleId { get; set; }
        public Module Module { get; set; }

        public ICollection<Assignment> Assignments { get; set; }

        public ICollection<Enrolment> Enrolments { get; set; }

        public ICollection<Lecture> Lectures { get; set; }
    }
}