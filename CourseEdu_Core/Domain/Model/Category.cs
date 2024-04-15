using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEdu_Core.Domain.Model
{
    public class Category
    {
        [Key] 
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Course>? Courses { get; set; }
        
    }
}
