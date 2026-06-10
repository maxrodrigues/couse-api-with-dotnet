using Course.Domain.Interfaces;

namespace Course.Infrastructure.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        public Task<Domain.Entities.Course> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Domain.Entities.Course>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Domain.Entities.Course course)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Domain.Entities.Course course)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}