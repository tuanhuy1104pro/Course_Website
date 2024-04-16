using CourseEdu_Core.Domain.Model;
using CourseEdu_Core.DTO;
using CourseEdu_Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEdu_Core.Services
{
    public class CategoryService : ICategoryServices
    {
        public Task<CategoryRespone> Add(CategoryAddRequest categoryAdd)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryRespone> Delete(CategoryRespone categoryRespone)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryRespone> Edit(CategoryRespone categoryRespone)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryRespone> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryRespone> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryRespone>> GetList()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryRespone> Update(CategoryRespone categoryRespone)
        {
            throw new NotImplementedException();
        }
    }
}
