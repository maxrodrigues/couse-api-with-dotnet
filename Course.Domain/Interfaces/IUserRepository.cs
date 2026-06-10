using Course.Domain.Entities;

namespace Course.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(int id);
        Task<List<User>> GetAllAsync();
        Task AddAsync(User category);
        Task UpdateAsync(int id, User category);
        Task DeleteAsync(int id);
    }
}
