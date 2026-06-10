using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Domain.Entities
{
    public class Lesson
    {
        public int Id { get; set; }
        public int ModuleId { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public int ContentType { get; set; }
        public string ?VideoUrl { get; set; }
        public string ?TextContent { get; set; }
        public int DurationInMinutes { get; set; } = 0;
        public int Order { get; set; }
        public bool IsFreePreview { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public DateTime? DeletedAt { get; set; }
        public Module Module { get; set; }
    }
}
