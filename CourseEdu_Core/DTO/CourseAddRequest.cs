using CourseEdu_Core.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEdu_Core.DTO
{
    public class CourseAddRequest
    {
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public double CoursePrice { get; set; }
        public string CategoryId { get; set; }

        public Course toCourse()
        {
            return new Course() { CourseName = CourseName, CourseDescription = CourseDescription, CoursePrice = CoursePrice, CategoryId = CategoryId };    
        }
    }
}
