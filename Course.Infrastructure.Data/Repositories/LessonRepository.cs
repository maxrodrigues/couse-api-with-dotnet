using Course.Domain.Entities;
using Course.Domain.Interfaces;
using Course.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Course.Infrastructure.Data.Repositories
{
    public class LessonRepository : ILessonRepository
    {
        private readonly AppDbContext _context;
        public async Task<Lesson> GetByIdAsync(int id)
        {
            return await _context.Lessons.Where(x => x.DeletedAt != null && x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Lesson>> GetAllAsync()
        {
            return await _context.Lessons.Where(x => x.DeletedAt != null).ToListAsync();
        }

        public async Task AddAsync(Lesson lesson)
        {
            _context.Lessons.Add(lesson);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, Lesson lesson)
        {
            _context.Lessons.Update(lesson);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var lesson = await this.GetByIdAsync(id);
            if (lesson != null)
            {
                lesson.DeletedAt = DateTime.Now;
                _context.Lessons.Update(lesson);

                await _context.SaveChangesAsync();
            }
        }
    }
}