using CourseEdu_Core.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEdu_Core.IServices
{
    public interface ICourseServices
    {
        public Task<List<Course>> GetList();
        public Task<Course> GetById(string id);
        public Task<Course> GetByName(string name);
        public Task<Course> Add();
        public Task<Course> Update();
        public Task<Course> Delete();
        public Task<Course> Edit();
    }
}
