using Course.Domain.Entities;
using Course.Domain.Interfaces;

namespace Course.Infrastructure.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<User> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(User category)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, User category)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}