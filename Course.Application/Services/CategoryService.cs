using Course.Application.DTO.Category;
using Course.Application.Interfaces;
using Course.Domain.Entities;
using Course.Domain.Interfaces;

namespace Course.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<GetCategoryDTO> AddAsync(StoreCategoryDTO category)
        {
            var categoryPayload = new Category
            {
                Name = category.Name,
                Slug = Utility.GenerateSlug(category.Name),
                Description = category.Description,
                IsActive = true,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };

            var createdCategory = await _categoryRepository.AddAsync(categoryPayload);
            return new GetCategoryDTO
            {
                Id = createdCategory.Id,
                Name = createdCategory.Name,
                Slug = createdCategory.Name,
                Description = createdCategory.Description,
                IsActive = createdCategory.IsActive,
                CreatedAt = createdCategory.CreatedAt,
                UpdatedAt = createdCategory.UpdatedAt,
            };
        }

        public async Task<List<GetCategoryDTO>> GetAllAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();
            var categoriesDTO = new List<GetCategoryDTO>();
            categoriesDTO.AddRange(categories.Select(categories => new GetCategoryDTO
            {
                Id = categories.Id,
                Name = categories.Name,
                Slug = categories.Slug,
                Description = categories.Description,
                CreatedAt = categories.CreatedAt,
                UpdatedAt = categories.UpdatedAt,
            }));

            return categoriesDTO;
        }

        public async Task<GetCategoryDTO> GetByIdAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category is null) return null;

            return new GetCategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                Slug = category.Slug,
                Description = category.Description,
                CreatedAt = category.CreatedAt,
                UpdatedAt = category.UpdatedAt,
            };
        }

        public async Task<GetCategoryDTO> UpdateAsync(int id, UpdateCategoryDTO category)
        {
            var foundedCategory = await _categoryRepository.GetByIdAsync(id);
            if (foundedCategory is null)
            {
                return null;
            }

            foundedCategory.Name = category.Name;
            foundedCategory.Slug = Utility.GenerateSlug(category.Name);
            foundedCategory.Description = category.Description;
            foundedCategory.UpdatedAt = DateTime.Now;

            var updatedCategory = await _categoryRepository.UpdateAsync(foundedCategory);
            return new GetCategoryDTO
            {
                Id = updatedCategory.Id,
                Name = updatedCategory.Name,
                Slug = updatedCategory.Slug,
                Description = updatedCategory.Description,
                CreatedAt = updatedCategory.CreatedAt,
                UpdatedAt = updatedCategory.UpdatedAt,
            };
        }
        public async Task<GetCategoryDTO> DeleteAsync(int id)
        {
            var foundedCategory = await _categoryRepository.GetByIdAsync(id);
            if (foundedCategory is null)
            {
                return null;
            }

            foundedCategory.DeletedAt = DateTime.Now;
            var deletedCategory = await _categoryRepository.UpdateAsync(foundedCategory);
            return new GetCategoryDTO
            {
                Id = deletedCategory.Id,
                Name = deletedCategory.Name,
                Slug = deletedCategory.Slug,
                Description = deletedCategory.Description,
                CreatedAt = deletedCategory.CreatedAt,
                UpdatedAt = deletedCategory.UpdatedAt,
                DeletedAt = deletedCategory.DeletedAt,
            };
        }
    }
}