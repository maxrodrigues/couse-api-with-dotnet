using Course.Domain.Interfaces;
using Course.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Course.Infrastructure.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly AppDbContext _context;
        public async Task<Domain.Entities.Course> GetByIdAsync(int id)
        {
            return await _context.Courses.Where(x => x.DeletedAt != null && x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Domain.Entities.Course>> GetAllAsync()
        {
            return await _context.Courses.Where(x => x.DeletedAt != null).ToListAsync();
        }

        public async Task AddAsync(Domain.Entities.Course course)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Domain.Entities.Course course)
        {
            _context.Courses.Update(course);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var course = await this.GetByIdAsync(id);
            if (course != null)
            {
                course.DeletedAt = DateTime.Now;
                _context.Courses.Update(course);

                await _context.SaveChangesAsync();
            }
        }
    }
}