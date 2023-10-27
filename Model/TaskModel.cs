using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Model
{
    public class TaskModel
    {
        public  int id { get; set; }
        [Required(ErrorMessage ="")]
        public int task_id { get; set; }
        [Required(ErrorMessage ="Task Name Cannot be not be blank"),MinLength(3,ErrorMessage ="Length must be atleast 3 characters")]
        public string task_name { get; set; }
        [Required(ErrorMessage ="Task Description is required"),MinLength(10,ErrorMessage ="Length must be atleast 10 characters")]
        public string? task_description { get; set;}
        /*[Required, Range(typeof(DateTime), "25/10/2023", "01/01/2060")]
        public DateTime due_date { get; set; }*/
        [Required]
        [CustomValidation(typeof(TaskModel),nameof(ValidateDate))]
        public DateTime due_date { get; set; }

        public bool task_staus { get; set; } = false;
        [Required(ErrorMessage ="this Priority level is required")]
        public int PriorityId { get; set; }
        public PriorityModel Priority { get; set; }

        public static ValidationResult ValidateDate(DateTime date, ValidationContext context)
        {
            if (date.Date < DateTime.Today)
            {
                return new ValidationResult("Date Must be greater than or equal to today's date.");
            }
            return ValidationResult.Success;
        }
    }
}
