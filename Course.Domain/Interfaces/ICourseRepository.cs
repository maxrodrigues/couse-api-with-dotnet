namespace Course.Domain.Interfaces
{
    public interface ICourseRepository
    {
        Task<Entities.Course> GetByIdAsync(int id);
        Task<List<Entities.Course>> GetAllAsync();
        Task<Entities.Course> AddAsync(Entities.Course course);
        Task<Entities.Course> UpdateAsync(Entities.Course course);
        Task<Entities.Course> DeleteAsync(int id);
    }
}