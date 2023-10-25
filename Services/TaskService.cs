using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Data;
using TaskManagementSystem.Model;

namespace TaskManagementSystem.Services
{
    public class TaskService
    {
        private readonly ApplicationDbContext _context;
        public TaskService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TaskModel>> Tasksasync()
        {
            return await _context.Tasks.Include(x=>x.Priority).ToListAsync();
        }
        public async Task AddTask (TaskModel task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateTask (TaskModel task)
        {
            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteTask (int id)
        {
            var item = await _context.Tasks.FindAsync(id);
            if (item != null)
            {
                _context.Tasks.Remove(item);
            }
            await _context.SaveChangesAsync();
        }
        public async Task<TaskModel> GetTask(int id)
        {
            var item= await _context.Tasks.FirstOrDefaultAsync(x=>x.id == id);
            if(item != null)
            {
                return item;
            }
            else
            {
                return null;
            }
        }
    }
}
