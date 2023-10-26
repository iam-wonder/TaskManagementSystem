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
            try
            {
                return await _context.Priorities.ToListAsync();
            }
            catch (Exception ex)
            {
                return new List<PriorityModel>();
            }
            
        }
        public async Task AddPriority (PriorityModel model)
        {
            try
            {
                _context.Priorities.Add(model);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

            }
            
        }
        public async Task UpdatePriority(PriorityModel model)
        {
            try
            {
                _context.Priorities.Update(model);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

            }
            
        }
        public async Task DeletePriority (int id)
        {
            try
            {
                var item = await _context.Priorities.FindAsync(id);
                if (item != null)
                {
                    _context.Priorities.Remove(item);
                }
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

            }
            
        }
        public async Task<PriorityModel> GetPriority (int id)
        {
            try
            {
                return await _context.Priorities.FindAsync (id);
            }
            catch(Exception ex)
            {
                return new PriorityModel();
            }
        }
    }
}
