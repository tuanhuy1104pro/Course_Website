using CourseEdu_Core.Domain.IRepository;
using CourseEdu_Core.Domain.Model;
using Infrastrucure.Dbcontext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucure.Repository
{
    public class CatergoryRepository : ICategoryRepository
    {
        private readonly CourseDbcontext _dbcontext;
        public CatergoryRepository(CourseDbcontext courseDbcontext)
        {
            _dbcontext = courseDbcontext;
        }

        public async Task<Category> AddCategory(Category category)
        {
           _dbcontext.Categories.Add(category);
            await _dbcontext.SaveChangesAsync();
            return category;
        }

        public async Task<bool> DeleteById(string id)
        {
            _dbcontext.Categories.RemoveRange(_dbcontext.Categories.Where(q => q.CategoryId == id));
            int rowselected = await _dbcontext.SaveChangesAsync();
            return rowselected > 0;
        }


        public async Task<Category> GetById(string id)
        {
            Category category = await _dbcontext.Categories.FirstOrDefaultAsync(temp => temp.CategoryId == id);
            return category;
        }

        public async Task<Category> GetByName(string name)
        {
           Category category = await _dbcontext.Categories.FirstOrDefaultAsync(temp => temp.CategoryName == name);
            return category;
        }

        async Task<List<Category>> ICategoryRepository.GetAll()
        {
          return await _dbcontext.Categories.ToListAsync();
        }
    }
}
