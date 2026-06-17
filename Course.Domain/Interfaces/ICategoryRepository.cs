using Course.Domain.Entities;

namespace Course.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Category> GetByIdAsync (int id);
        Task<List<Category>> GetAllAsync ();
        Task<Category> AddAsync (Category category);
        Task<Category> UpdateAsync (Category category);
        Task DeleteAsync (int id);
    }
}
