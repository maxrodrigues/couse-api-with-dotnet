namespace Course.Domain.Interfaces
{
    public interface ICourseRepository
    {
        Task<Entities.Course> GetByIdAsync(int id);
        Task<IEnumerable<Entities.Course>> GetAllAsync();
        Task AddAsync(Entities.Course course);
        Task UpdateAsync(Entities.Course course);
        Task DeleteAsync(int id);
    }
}