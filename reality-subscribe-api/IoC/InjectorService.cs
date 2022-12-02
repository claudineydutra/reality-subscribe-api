using Infra.DBConfiguration.EFCore;

namespace reality_subscribe_api.IoC
{
    public static class InjectorService
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //Repositorys

            services.AddHttpContextAccessor();
        }
    }
}
