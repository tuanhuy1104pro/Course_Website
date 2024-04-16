using CourseEdu_Core.Domain.IRepository;
using CourseEdu_Core.Domain.Model;
using CourseEdu_Core.DTO;
using CourseEdu_Core.Enum;
using CourseEdu_Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEdu_Core.Services
{
    public class CourseServices : ICourseServices
    {
        private readonly ICourseRepository _courseRepository;
        public CourseServices(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public Task<CourseRespone> AddCourse(CourseAddRequest course)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CourseRespone>> FilterCourse(string searchBy, string searchString)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CourseRespone>> GetAll()
        {
           List<Course> listCourse = await _courseRepository.GetAll();
            return listCourse.Select(temp => temp.toCourseRespone()).ToList();
        }

        public Task<CourseRespone> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CourseRespone> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<CourseRespone>> SortedCourse(List<CourseRespone> courseList, SortOrder sortOrder, string sortBy)
        {
            throw new NotImplementedException();
        }

        public Task<CourseRespone> UpdateCourse(CourseRespone courseRespone)
        {
            throw new NotImplementedException();
        }
    }
}
