using CourseEdu_Core.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEdu_Core.DTO
{
    public class CourseRespone
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public double CoursePrice { get; set; }
        public string CategoryId { get; set; }
        public string TeachName { get; set; }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if(obj.GetType() != typeof(CourseRespone)) return false;

            CourseRespone other = (CourseRespone)obj;
            return CourseId == other.CourseId && CourseName == other.CourseName && CourseDescription == other.CourseDescription && CoursePrice == other.CoursePrice && CategoryId == other.CategoryId && TeachName == other.TeachName;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    public static class CourseExtension
    {
        public static CourseRespone toCourseRespone(this Course coue)
        {
            return new CourseRespone() { CourseId = coue.CourseId, CourseName = coue.CourseName, CoursePrice = coue.CoursePrice, CategoryId = coue.CategoryId, CourseDescription = coue.CourseDescription, TeachName = coue.TeachName };
        }
    }
}
