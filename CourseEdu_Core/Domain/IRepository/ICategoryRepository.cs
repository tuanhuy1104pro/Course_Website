using CourseEdu_Core.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEdu_Core.Domain.IRepository
{
    public interface ICategoryRepository
    {
        public  Task<Category> AddCategory(Category category);
        public Task<List<Category>> GetAll();
        public Task<Category> GetById(string id);
        public Task<Category> GetByName(string id);
        public Task<bool> DeleteById(string id);
    }
}
