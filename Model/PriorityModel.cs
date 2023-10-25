using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Model
{
    public class PriorityModel
    {
        public int id { get; set; }
        [Required]
        public string priority_name { get; set; }
    }
}
