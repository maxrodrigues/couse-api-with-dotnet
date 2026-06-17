using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Course.Application.DTO.Category
{
    public class StoreCategoryDTO
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Titulo do curso pode ser somente até 50 caracteres")]
        public string Name { get; set; }

        [JsonIgnore]
        public string? Slug { get; set; }

        [Required]
        [MaxLength(240, ErrorMessage = "Titulo do curso pode ser somente até 240 caracteres")]
        public string Description { get; set; }

        [JsonIgnore]
        public bool IsActive { get; set; } = true;

        [JsonIgnore]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [JsonIgnore]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
