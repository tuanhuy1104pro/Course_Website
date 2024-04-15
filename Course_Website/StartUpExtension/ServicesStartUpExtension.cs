using CourseEdu_Core.Domain.IRepository;
using Infrastrucure.Dbcontext;
using Microsoft.EntityFrameworkCore;
using Infrastrucure.Repository;
namespace Course_Website.StartUpExtension
{
    public static class ServicesStartUpExtension
    {
        public static IServiceCollection ServicesStartUp (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllersWithViews ();
            services.AddTransient<ICategoryRepository, CatergoryRepository>();
            services.AddTransient<ICourseRepository, CourseRepository>();
            services.AddDbContext<CourseDbcontext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("Default"));
            });
            return services;
        }
    }
}
