using Course.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Domain.Interfaces
{
    public interface IModuleRepository
    {
        Task<Module> GetByIdAsync(int id);
        Task<List<Module>> GetAllAsync();
        Task AddAsync(Module category);
        Task UpdateAsync(int id, Module category);
        Task DeleteAsync(int id);
    }
}
