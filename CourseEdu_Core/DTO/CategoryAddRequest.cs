using CourseEdu_Core.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEdu_Core.DTO
{
    public class CategoryAddRequest
    {
        public string? CategoryName { get; set; }
        public  Category ToCategory()
        {
            return new Category() {CategoryName = CategoryName };
        }
        
    }
}
