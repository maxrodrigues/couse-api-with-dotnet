using Course.Application.DTO.Category;

namespace Course.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<GetCategoryDTO> GetByIdAsync(int id);
        Task<List<GetCategoryDTO>> GetAllAsync();
        Task<GetCategoryDTO> AddAsync(StoreCategoryDTO category);
        Task<GetCategoryDTO> UpdateAsync(int id, UpdateCategoryDTO category);
        Task<GetCategoryDTO> DeleteAsync(int id);
    }
}
