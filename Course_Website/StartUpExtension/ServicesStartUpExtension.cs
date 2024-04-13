namespace Course_Website.StartUpExtension
{
    public static class ServicesStartUpExtension
    {
        public static IServiceCollection ServicesStartUp (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllersWithViews ();
            
            return services;
        }
    }
}
