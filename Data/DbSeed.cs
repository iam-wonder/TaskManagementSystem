using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Model;

namespace TaskManagementSystem.Data
{
    public class DbSeed
    {
        private readonly ModelBuilder modelBuilder;

    
        private List<PriorityModel> priorities = new List<PriorityModel> { 
            new PriorityModel{ id=1,priority_name="Lowest", priority_level=1 },
            new PriorityModel{ id=2,priority_name="Low", priority_level=2 },
            new PriorityModel{ id=3,priority_name="Medium", priority_level=3 },
            new PriorityModel{ id=4,priority_name="High", priority_level=4 },
            new PriorityModel{ id=5,priority_name="Highest", priority_level=5 },
        };
        private List<TaskModel> tasks = new List<TaskModel> {
            new TaskModel{id=1, task_id=1, task_name="Cook", task_description="Cook Dinner for everyone at home" , PriorityId=1, due_date=DateTime.Now.Date , task_staus=false },
            new TaskModel{id=2, task_id=2, task_name="Clean the Dishes", task_description="Wash the Plates before going to bed" , PriorityId=1, due_date=DateTime.Now.Date,task_staus = false },
            new TaskModel{id=3, task_id=3, task_name="Grocery Shoping", task_description="Get the essential Groceries on the Grocery List" , PriorityId=2, due_date=DateTime.Now.Date, task_staus = true },
        };
        

        public DbSeed(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void DbSeeder()
        {
            modelBuilder.Entity<PriorityModel>().HasData(priorities);
            modelBuilder.Entity<TaskModel>().HasData(tasks);
        }
    }
}
