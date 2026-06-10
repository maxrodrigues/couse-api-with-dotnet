using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string ?Description { get; set; }
        public int Price { get; set; } = 0;
        public int DurationInHours { get; set; } = 0;
        public int Status { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt {  get; set; } = DateTime.Now;
        public DateTime ?DeletedAt {  get; set; }
        public Category Category { get; set; }
        public User User { get; set; }
        public ICollection<Module> Modules { get; set; }
    }
}
