using CourseEdu_Core.Domain.Model;
using CourseEdu_Core.DTO;
using CourseEdu_Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEdu_Core.IServices
{
    public interface ICourseServices
    {
        public Task<CourseRespone> AddCourse(CourseAddRequest course);
        public Task<List<CourseRespone>> GetAll();
        public Task<CourseRespone> GetById(int id);
        public Task<CourseRespone> GetByName(string name);
        public Task<bool> DeleteById(int id);
        public Task<CourseRespone> UpdateCourse(CourseRespone courseRespone);
        public Task<List<CourseRespone>> FilterCourse(string searchBy, string searchString);
        public Task<List<CourseRespone>> SortedCourse(List<CourseRespone> courseList, SortOrder sortOrder, string sortBy);
    }
}
