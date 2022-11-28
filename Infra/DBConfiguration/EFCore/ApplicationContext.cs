using Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using reality_subscribe_api.Model;

namespace Infra.DBConfiguration.EFCore
{
    public class ApplicationContext : DbContext
    {
        /* Creating DatabaseContext without Dependency Injection */
        public ApplicationContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                var service = Configuration.GetService(Configuration.Service);
                dbContextOptionsBuilder.UseSqlServer(service.ConnectionString);
            }
        }

        /* Creating DatabaseContext configured by Dependency Injection */
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Usuario> User { get; set; }
        public DbSet<Inscricao> TaskToDo { get; set; }
    }
}
