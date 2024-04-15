using CourseEdu_Core.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEdu_Core.Domain.IRepository
{
    public interface ICourseRepository
    {
        public Task<Course> AddCourse(Course category);
        public Task<List<Course>> GetAll();
        public Task<Course> GetById(int id);
        public Task<Course> GetByName(string name);
        public Task<bool> DeleteById(int id);
        public Task<Course> UpdateCourse(Course course);
    }
}
