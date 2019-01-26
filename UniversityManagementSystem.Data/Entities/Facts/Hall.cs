using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Data.Entities.Facts
{
    [Table("W_HALLS_F")]
    public class Hall
    {
        public int CampusId { get; set; }
        public Dimensions.Campus Campus { get; set; }
        
        public int NoOfHalls { get; set; }
    }
}