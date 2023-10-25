using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Data;
using TaskManagementSystem.Model;

namespace TaskManagementSystem.Services
{
    public class PriorityService
    {
        private readonly ApplicationDbContext _context;
        public PriorityService(ApplicationDbContext context) 
        {
            _context = context;
        }

        public async Task<List<PriorityModel>> GetPriorities()
        {
            return await _context.Priorities.ToListAsync();
        }
        public async Task AddPriority (PriorityModel model)
        {
            _context.Priorities.Add(model);
            await _context.SaveChangesAsync();
        }
        public async Task UpdatePriority(PriorityModel model)
        {
            _context.Priorities.Update(model);
            await _context.SaveChangesAsync();
        }
        public async Task DeletePriority (int id)
        {
            var item = await _context.Priorities.FindAsync(id);
            if (item != null)
            {
                _context.Priorities.Remove(item);
            }
            await _context.SaveChangesAsync();
        }
    }
}
