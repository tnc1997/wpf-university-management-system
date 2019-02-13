using System.Collections.Generic;

namespace UniversityManagementSystem.Data.Entities
{
    public class DimClassification
    {
        public int Id { get; set; }

        public string Classification { get; set; }

        public ICollection<FactStudent> Students { get; set; }
    }
}