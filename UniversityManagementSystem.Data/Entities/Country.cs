using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class Country : EntityBase
    {
        public string Name { get; set; }
        
        public ICollection<User> Users { get; set; }
    }
}