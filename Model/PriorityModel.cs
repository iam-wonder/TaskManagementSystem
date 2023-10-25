using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Model
{
    public class PriorityModel
    {
        public int id { get; set; }
        [Required(ErrorMessage ="priority has to have a name"),MinLength(3,ErrorMessage ="Must have atleast 3 Characters")]
        public string priority_name { get; set; }
    }
}
