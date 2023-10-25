using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
            try
            {
                return await _context.Tasks.Include(x => x.Priority).ToListAsync();
            }
            catch (Exception ex)
            {
                return new List<TaskModel>();
                
            }

           
        }
        public async Task AddTask (TaskModel task)
        {
            try
            {
                _context.Tasks.Add(task);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {

            }
            catch (Exception ex)
            {

            }
            
        }
        public async Task UpdateTask (TaskModel task)
        {
            try
            {
                _context.Tasks.Update(task);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateException ex)
            {

            }
            
            catch (Exception ex)
            {

            }
            
        }
        public async Task DeleteTask (int id)
        {
            try
            {
                var item = await _context.Tasks.FindAsync(id);
                if (item != null)
                {
                    _context.Tasks.Remove(item);
                }
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                
            }
            
        }
        public async Task<TaskModel> GetTask(int id)
        {
            try
            {
                var item = await _context.Tasks.FirstOrDefaultAsync(x => x.id == id);
                if (item != null)
                {
                    return item;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex) {
                return null;
            }
            
        }
    }
}
