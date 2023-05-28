using Microsoft.EntityFrameworkCore;
using XProject.Domain.Entitities;
using XProject.Domain.Interfaces;

namespace XProject.Infra.Data
{
    public class ViewRepository : IAppPageRepository
    {
        private readonly ApplicationDbContext _context;

        public ViewRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<AppPage> Create(AppPage view)
        {
            _context.Add(view);
            await _context.SaveChangesAsync();
            return view;
        }

        public async Task<List<AppPage>> GetAll()
        {
            return await _context.Views.ToListAsync();
        }

        public async Task<AppPage?> GetById(string id)
        {
            return await _context.Views.FindAsync(id);
        }
        
        public async Task<AppPage?> GetByName(string name)
        {
            return await _context.Views.FirstOrDefaultAsync(i => i.Name == name);
        }

        public async Task<AppPage> Update(AppPage view)
        {
            _context.Update(view);
            await _context.SaveChangesAsync();
            return view;
        }

        public async Task<AppPage> Remove(AppPage view)
        {
            _context.Remove(view);
            await _context.SaveChangesAsync();
            return view;
        }
        
    }
}
