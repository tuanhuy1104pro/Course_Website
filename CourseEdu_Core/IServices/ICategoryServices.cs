using CourseEdu_Core.Domain.Model;
using CourseEdu_Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEdu_Core.IServices
{
    public interface ICategoryServices
    {
        public Task<List<CategoryRespone>> GetList();
        public Task<CategoryRespone> GetById(string id);
        public Task<CategoryRespone> GetByName(string name);
        public Task<CategoryRespone> Add(CategoryAddRequest categoryAdd);
        public Task<CategoryRespone> Update(CategoryRespone categoryRespone);
        public Task<CategoryRespone> Delete(CategoryRespone categoryRespone);
        public Task<CategoryRespone> Edit(CategoryRespone categoryRespone);

    }
}
