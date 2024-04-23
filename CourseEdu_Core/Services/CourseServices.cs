﻿using CourseEdu_Core.Domain.IRepository;
using CourseEdu_Core.Domain.Model;
using CourseEdu_Core.DTO;
using CourseEdu_Core.Enum;
using CourseEdu_Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEdu_Core.Services
{
    public class CourseServices : ICourseServices
    {
        private readonly ICourseRepository _courseRepository;
        private readonly ICategoryServices _categoryServices;
        public CourseServices(ICourseRepository courseRepository, ICategoryServices categoryServices)
        {
            _courseRepository = courseRepository;
            _categoryServices = categoryServices;   
        }
        public Task<CourseRespone> AddCourse(CourseAddRequest course)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteById(int id)
        {
            bool result =await _courseRepository.DeleteById(id);
            return result;
        }

        public async Task<List<CourseRespone>> FilterCourse(string searchBy, string searchString)
        {
            List<CourseRespone> allCourse = await GetAll();
            List<CourseRespone> matchPersons = await GetAll();
            if(string.IsNullOrEmpty(searchBy) || string.IsNullOrEmpty(searchString)
            {
                return matchPersons;
            }
            switch (searchBy)
            {
                case nameof(CourseRespone.CourseName):
                    {
                        matchPersons = allCourse.Where(temp => )
                        break;
                    }
                  
                default:
                    break;
            }
        }

        public async Task<List<CourseRespone>> GetAll()
        {
           List<Course> listCourse = await _courseRepository.GetAll();
            return listCourse.Select(temp => temp.toCourseRespone()).ToList();
        }

        public async Task<CourseRespone> GetById(int id)
        {
            if(id == null) throw new ArgumentNullException("id miss");
            Course course = await _courseRepository.GetById(id);
            return course.toCourseRespone();
        }

        public async Task<CourseRespone> GetByName(string name)
        {
           Course cours = await _courseRepository.GetByName(name);
            if(cours == null) throw new ArgumentNullException("Course dont exist");
            return cours.toCourseRespone();
        }

        public async Task<List<CourseRespone>> SortedCourse(List<CourseRespone> courseList, SortOrder sortOrder, string sortBy)
        {
           if(string.IsNullOrEmpty(sortBy))
            {
                return courseList;
            }
            List<CourseRespone> sortedCourses = (sortBy, sortOrder) switch
            {
                (nameof(CourseRespone.CourseName),SortOrder.Ascending) =>
                 courseList.OrderBy(temp => temp.CourseName,StringComparer.OrdinalIgnoreCase).ToList(),
                (nameof(CourseRespone.CourseName), SortOrder.Descending) =>
              courseList.OrderByDescending(temp => temp.CourseName, StringComparer.OrdinalIgnoreCase).ToList(),
                (nameof(CourseRespone.CoursePrice), SortOrder.Ascending) =>
                   courseList.OrderBy(temp => temp.CourseName, StringComparer.OrdinalIgnoreCase).ToList(),
                (nameof(CourseRespone.CoursePrice), SortOrder.Descending) =>
              courseList.OrderByDescending(temp => temp.CourseName, StringComparer.OrdinalIgnoreCase).ToList(),
                _ => courseList

            };
            return sortedCourses;
        }

        public Task<CourseRespone> UpdateCourse(CourseRespone courseRespone)
        {
            throw new NotImplementedException();
        }
    }
}
