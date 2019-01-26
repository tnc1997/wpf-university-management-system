using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Data.Entities.Dimensions
{
    [Table("W_MODULES_D")]
    public class Module
    {
        public int Id { get; set; }
        
        public string Code { get; set; }
        
        public string Title { get; set; }
        
        public ICollection<Facts.Student> Students { get; set; }
    }
}