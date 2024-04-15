using Infrastrucure.Dbcontext;
using Microsoft.EntityFrameworkCore;
namespace Course_Website.StartUpExtension
{
    public static class ServicesStartUpExtension
    {
        public static IServiceCollection ServicesStartUp (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllersWithViews ();
            services.AddDbContext<CourseDbcontext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("Default"));
            });
            return services;
        }
    }
}
