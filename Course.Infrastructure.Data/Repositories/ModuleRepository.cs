using Course.Domain.Entities;
using Course.Domain.Interfaces;

namespace Course.Infrastructure.Data.Repositories
{
    public class ModuleRepository :  IModuleRepository
    {
        public Task<Module> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Module>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Module category)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, Module category)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}