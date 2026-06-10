using Course.Domain.Entities;

namespace Course.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Category> GetByIdAsync (int id);
        Task<List<Category>> GetAllAsync ();
        Task AddAsync (Category category);
        Task UpdateAsync (int id, Category category);
        Task DeleteAsync (int id);
    }
}
