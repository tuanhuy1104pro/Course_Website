using CourseEdu_Core.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEdu_Core.IServices
{
    public interface ICategoryServices
    {
        public Task<List<Category>> GetList();
        public Task<Category> GetById(string id);
        public Task<Category> GetByName(string name);
        public Task<Category> Add();
        public Task<Category> Update();
        public Task<Category> Delete();
        public Task<Category> Edit();

    }
}
