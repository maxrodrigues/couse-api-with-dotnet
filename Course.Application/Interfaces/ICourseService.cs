using Course.Application.DTO.Course;

namespace Course.Application.Interfaces
{
    public interface ICourseService
    {
        Task<GetCourseDTO> GetByIdAsync(int id);
        Task<List<GetCourseDTO>> GetAllAsync();
        Task<GetCourseDTO> AddAsync(StoreCourseDTO course);
        Task<GetCourseDTO> UpdateAsync(UpdateCourseDTO course);
        Task<GetCourseDTO> DeleteAsync(int id);
    }
}
