using CourseEdu_Core.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEdu_Core.DTO
{
    public class CategoryRespone
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

        public override bool Equals(object? obj)
        {
            if(obj == null) return false;
            if (obj.GetType() != typeof(CategoryRespone))
            {
                return false;
            }
            CategoryRespone categoryRespone = (CategoryRespone)obj;
            return CategoryId == categoryRespone.CategoryId && CategoryName == categoryRespone.CategoryName;
            
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    public  static class CategoryExtension
    {
        public static CategoryRespone toCategoryRespone(this Category category)
        {
            return new CategoryRespone(){CategoryId = category.CategoryId,CategoryName = category.CategoryName};
        }
    }
}
