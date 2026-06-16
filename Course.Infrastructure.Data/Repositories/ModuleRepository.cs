using Course.Domain.Entities;
using Course.Domain.Interfaces;
using Course.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Course.Infrastructure.Data.Repositories
{
    public class ModuleRepository :  IModuleRepository
    {
        private readonly AppDbContext _context;
        public async Task<Module> GetByIdAsync(int id)
        {
            return await _context.Modules.Where(x => x.DeletedAt != null && x.Id ==  id).FirstOrDefaultAsync();
        }

        public async Task<List<Module>> GetAllAsync()
        {
            return await _context.Modules.Where(x => x.DeletedAt != null).ToListAsync();
        }

        public async Task AddAsync(Module module)
        {
            _context.Modules.Add(module);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, Module module)
        {
            _context.Modules.Update(module);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var module = await this.GetByIdAsync(id);
            if (module != null)
            {
                module.DeletedAt = DateTime.Now;
                _context.Modules.Update(module);

                await _context.SaveChangesAsync();
            }
        }
    }
}