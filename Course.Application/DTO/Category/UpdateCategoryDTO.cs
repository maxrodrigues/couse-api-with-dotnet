using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Course.Application.DTO.Category
{
    public class UpdateCategoryDTO
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public string? Slug { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public bool? IsActive { get; set; }

        [JsonIgnore]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [JsonIgnore]
        public DateTime DeletedAt { get; set; } = DateTime.Now;
    }
}
