using CourseEdu_Core.Domain.IRepository;
using Infrastrucure.Dbcontext;
using Microsoft.EntityFrameworkCore;
using Infrastrucure.Repository;
using CourseEdu_Core.IServices;
using CourseEdu_Core.Services;
namespace Course_Website.StartUpExtension
{
    public static class ServicesStartUpExtension
    {
        public static IServiceCollection ServicesStartUp (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllersWithViews ();
            services.AddTransient<ICategoryRepository, CatergoryRepository>();
            services.AddTransient<ICourseRepository, CourseRepository>();
            services.AddTransient<ICategoryServices,CategoryService>();
            services.AddTransient<ICourseServices, CourseServices>();

            services.AddDbContext<CourseDbcontext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("Default"));
            });
            return services;
        }
    }
}
