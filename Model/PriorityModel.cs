using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementSystem.Model
{
    public class PriorityModel
    {
        
        public int id { get; set; }
        [Required(ErrorMessage ="priority has to have a name"),MinLength(3,ErrorMessage ="Must have atleast 3 Characters")]
        public string priority_name { get; set; }

        [Required(ErrorMessage ="Please Ente A number to Set as Priority Level"),Range(1,5,ErrorMessage ="Please Enter a Number with the Ranges of 1 to 5 and only whole number are allowed")]
        
        public int priority_level { get; set; } 
    }
    public class  UniqueInteger: ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if(value is int intValue)
            {
                var instance = validationContext.ObjectInstance;
                var property = validationContext.ObjectType.GetProperty(validationContext.MemberName);

                var currentValue = (int)property.GetValue(instance);
                if(intValue == currentValue)
                {
                    return new ValidationResult(ErrorMessage);
                }
            }
            return ValidationResult.Success;
        }
    }
}
