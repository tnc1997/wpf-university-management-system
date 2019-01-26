using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Data.Entities.Facts
{
    [Table("W_LIBRARIES_F")]
    public class Library
    {
        public int CampusId { get; set; }
        public Dimensions.Campus Campus { get; set; }
        
        public int NoOfLibraries { get; set; }
    }
}