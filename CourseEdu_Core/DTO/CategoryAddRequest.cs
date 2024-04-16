using CourseEdu_Core.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEdu_Core.DTO
{
    public class CategoryAddRequest
    {
        [Required(ErrorMessage = "Name cannot be blank")]
        public string? CategoryName { get; set; }
        public  Category ToCategory()
        {
            return new Category() {CategoryName = CategoryName };
        }
        
    }
}
