using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class Library : EntityBase
    {
        public string Name { get; set; }

        public int CampusId { get; set; }
        public Campus Campus { get; set; }

        public ICollection<LibraryBook> LibraryBooks { get; set; }
    }
}