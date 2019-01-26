using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Data.Entities.Facts
{
    [Table("W_ROOMS_F")]
    public class Room
    {
        public int CampusId { get; set; }
        public Dimensions.Campus Campus { get; set; }
        
        public int NoOfRooms { get; set; }
    }
}