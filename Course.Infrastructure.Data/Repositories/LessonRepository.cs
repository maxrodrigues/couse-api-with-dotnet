using Course.Domain.Entities;
using Course.Domain.Interfaces;

namespace Course.Infrastructure.Data.Repositories
{
    public class LessonRepository : ILessonRepository
    {
        public Task<Lesson> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Lesson>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Lesson category)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, Lesson category)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}