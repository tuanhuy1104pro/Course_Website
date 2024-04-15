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
    public class CourseRepository : ICourseRepository
    {
        private readonly CourseDbcontext _dbcontext;
        public CourseRepository(CourseDbcontext courseDbcontext)
        {
            _dbcontext = courseDbcontext;
        }

        public async Task<Course> AddCourse(Course course)
        {
            _dbcontext.Courses.Add(course);
            await _dbcontext.SaveChangesAsync();
            return course;
        }

        public async Task<bool> DeleteById(int id)
        {
            Course course = await _dbcontext.Courses.FirstOrDefaultAsync(temp => temp.CourseId == id);
            if (course != null)
            {
                _dbcontext.Courses.Remove(course);
                return true;
            }
            return false;
            
        }

        public async Task<List<Course>> GetAll()
        {
           return await _dbcontext.Courses.ToListAsync();
        }

        public async Task<Course> GetById(int id)
        {
          Course course=  await _dbcontext.Courses.FirstOrDefaultAsync(temp => temp.CourseId == id);
            return course;
        }

        public async Task<Course> GetByName(string name)
        {
            Course course = await _dbcontext.Courses.FirstOrDefaultAsync(temp => temp.CourseName == name);
            return course;
        }

        public async Task<Course> UpdateCourse(Course course)
        {
            //Matching course 
            Course matchingCourse = await _dbcontext.Courses.FirstOrDefaultAsync(temp => temp.CourseId == course.CourseId);
            if(matchingCourse == null)
            {
                 new ArgumentException("Course didn't exist");
                return course;
            }
            matchingCourse.CourseName = course.CourseName;
            matchingCourse.CourseDescription = course.CourseDescription;
            matchingCourse.CoursePrice = course.CoursePrice;
            matchingCourse.CategoryId = course.CategoryId;
            // UPdate
            int countUpdate = await _dbcontext.SaveChangesAsync();
            return matchingCourse;
        }
    }
}
