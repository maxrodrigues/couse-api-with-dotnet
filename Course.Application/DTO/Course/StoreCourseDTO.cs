using System.ComponentModel.DataAnnotations;

namespace Course.Application.DTO.Course
{
    public class StoreCourseDTO
    {
        [Required(ErrorMessage = "")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "")]
        [MaxLength(100, ErrorMessage = "")]
        public string Title { get; set; }
        public string Slug { get; set; }
        
        [MaxLength(100, ErrorMessage = "")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "")]
        public int Price { get; set; }

        [Required(ErrorMessage = "")]
        public int DurationInHours { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
