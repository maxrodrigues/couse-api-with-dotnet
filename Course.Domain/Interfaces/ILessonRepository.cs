using Course.Domain.Entities;

namespace Course.Domain.Interfaces
{
    public interface ILessonRepository
    {
        Task<Lesson> GetByIdAsync(int id);
        Task<List<Lesson>> GetAllAsync();
        Task AddAsync(Lesson category);
        Task UpdateAsync(int id, Lesson category);
        Task DeleteAsync(int id);
    }
}
