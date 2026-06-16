using Course.Domain.Entities;
using Course.Domain.Interfaces;

namespace Course.Infrastructure.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public Task<Category> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, Category category)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}