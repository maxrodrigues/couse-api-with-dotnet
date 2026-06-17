using Course.Application.DTO.Course;
using Course.Application.Interfaces;
using Course.Domain.Entities;
using Course.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService (ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<GetCourseDTO> AddAsync(StoreCourseDTO course)
        {
            var coursePayload = new Domain.Entities.Course
            {
                // Parametros do DTO
                Title = course.Title
            };

            var createdCourse = await _courseRepository.AddAsync(coursePayload);
            return new GetCourseDTO
            {
                Title = course.Title,
            };
        }

        public async Task<GetCourseDTO> DeleteAsync(int id)
        {
            var deletedCourse = await _courseRepository.DeleteAsync(id);
            if (deletedCourse != null)
            {
                return new GetCourseDTO
                {
                    Id = deletedCourse.Id,
                };
            }

            return null;

        }

        public async Task<List<GetCourseDTO>> GetAllAsync()
        {
            var courses = await _courseRepository.GetAllAsync();
            var coursesGetDTO = new List<GetCourseDTO>();
            coursesGetDTO.AddRange(courses.Select(c => new GetCourseDTO
            {
                Id= c.Id,
            }));

            return coursesGetDTO;
        }

        public async Task<GetCourseDTO> GetByIdAsync(int id)
        {
            var course = await _courseRepository.GetByIdAsync(id);
            if (course != null)
            {
                return new GetCourseDTO
                {
                    Id = course.Id,
                };
            }

            return null;
            
        }

        public async Task<GetCourseDTO> UpdateAsync(UpdateCourseDTO course)
        {
            var coursePayload = new Domain.Entities.Course
            {
                // Parametros do DTO
            };

            var createdCourse = await _courseRepository.UpdateAsync(coursePayload);
            return new GetCourseDTO
            {
                // Parametros do DTO
            };
        }
    }
}
