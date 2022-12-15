using Application.Infra;
using Infra.DBConfiguration.EFCore;
using Infra.Repository;
using reality_subscribe_api.Model;

namespace reality_subscribe_api.IoC
{
    public static class InjectorService
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //Repositorys
            services.AddScoped<IARepository<Subscribe>, SubscribeRepository>();

            services.AddHttpContextAccessor();
        }
    }
}
