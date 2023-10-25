using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Model
{
    public class TaskModel
    {
        public  int id { get; set; }
        [Required]
        public int task_id { get; set; }
        [Required,MinLength(3)]
        public string task_name { get; set; }
        [Required,MinLength(10)]
        public string? task_description { get; set;}
        [Required]
        public DateTime due_date { get; set; }
        public bool task_staus { get; set; } = false;
        
        public int PriorityId { get; set; }
        public PriorityModel Priority { get; set; }
    }
}
