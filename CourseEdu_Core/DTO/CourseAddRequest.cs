using CourseEdu_Core.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEdu_Core.DTO
{
    public class CourseAddRequest
    {
        [Required(ErrorMessage ="Name cannot be blank")]
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        [Required(ErrorMessage = "Name cannot be blank")]
        [RegularExpression("^[0-9]+$",ErrorMessage ="Must be number")]
        public double CoursePrice { get; set; }
        [Required(ErrorMessage = "Id cannot be blank")]
        public string CategoryId { get; set; }

        public Course toCourse()
        {
            return new Course() { CourseName = CourseName, CourseDescription = CourseDescription, CoursePrice = CoursePrice, CategoryId = CategoryId };    
        }
    }
}
