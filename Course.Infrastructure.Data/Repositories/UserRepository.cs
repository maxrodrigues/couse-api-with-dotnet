using Course.Domain.Entities;
using Course.Domain.Interfaces;
using Course.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Course.Infrastructure.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task AddAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var user = await this.GetByIdAsync(id);
            if (user != null)
            {
                user.DeletedAt = DateTime.Now;
                _context.Users.Update(user);

                await _context.SaveChangesAsync();
            }
        }
    }
}