using CourseEdu_Core.Domain.IRepository;
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
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<CategoryRespone> Add(CategoryAddRequest categoryAdd)
        {
            if(categoryAdd == null)
            {
                throw new ArgumentException("Some things miss");
            }
            if(await _categoryRepository.GetByName(categoryAdd.CategoryName) != null)
            {
                throw new ArgumentException("Đã có category đó rồi ní");
            }
            Category category = categoryAdd.ToCategory();
            Category result = await _categoryRepository.AddCategory(category);
            return result.toCategoryRespone();
        }

        public async Task<CategoryRespone> Delete(string id)
        {
            if(id == null)
            {
                throw new ArgumentException("SomeThing misstake");
            }
            Category category = await _categoryRepository.GetById(id);
            if(category == null)
            {
                throw new ArgumentException("Không tồn tại cate cần xóa");
            }    
            await _categoryRepository.DeleteById(category.CategoryId);
            return category.toCategoryRespone();

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

        public async Task<List<CategoryRespone>> GetList()
        {

           return (await _categoryRepository.GetAll()).Select(temp => temp.toCategoryRespone()).ToList();
        }

        public Task<CategoryRespone> Update(CategoryRespone categoryRespone)
        {
            throw new NotImplementedException();
        }
    }
}
