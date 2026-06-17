using Course.Application.DTO.Category;
using Course.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace Course.Api.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllCategories()
        {
            var categories = await _categoryService.GetAllAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category is null) return NotFound();

            return Ok(category);
        }

        [HttpPost]
        public async Task<ActionResult> StoreCategory(StoreCategoryDTO categoryDTO)
        {
            var category = await _categoryService.AddAsync(categoryDTO);
            if (category is null) return BadRequest("Erro ao gravar");

            return Created();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, UpdateCategoryDTO categoryDTO)
        {
            var category = await _categoryService.UpdateAsync(id, categoryDTO);
            if (category is null) return NotFound();

            return Ok(category);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _categoryService.DeleteAsync(id);
            if (category is null) return NotFound();

            return Ok(category);
        }
    }
}
