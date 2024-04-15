using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseEdu_Core.Domain.Model;
using Microsoft.EntityFrameworkCore;
namespace Infrastrucure.Dbcontext
{
    public class CourseDbcontext : DbContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Course> Courses { get; set; }
        public CourseDbcontext(DbContextOptions option) : base(option)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Category category = new Category() { CategoryId = "CA834AA4-7F87-4DF5-A29E-A856071BE701",CategoryName = "History"};
            Category category2 = new Category() { CategoryId = "AE4B2F2E-2C3C-44C6-AB6F-4618254EEF91", CategoryName = "IT" };
            modelBuilder.Entity<Category>().HasData(category);
            modelBuilder.Entity<Category>().HasData(category2);

            string CourseData = System.IO.File.ReadAllText("MOCK_DATA.json");
            
            List<Course> courses = System.Text.Json.JsonSerializer.Deserialize<List<Course>>(CourseData);
            foreach (Course item in courses)
            {
                modelBuilder.Entity<Course>().HasData(item);
            }
            
        }
    }
}
