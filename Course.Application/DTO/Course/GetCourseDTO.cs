namespace Course.Application.DTO.Course
{
    public class GetCourseDTO
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        public int DurationInHours { get; set; }
        public int Status { get; set; }
    }
}
