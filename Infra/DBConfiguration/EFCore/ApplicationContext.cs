﻿using Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using reality_subscribe_api.Model;
using System.Diagnostics;

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
                var service = RealityCoreConfiguration.GetService(RealityCoreConfiguration.Service);
                dbContextOptionsBuilder.UseSqlServer(service.ConnectionString);

                if (Debugger.IsAttached)
                {
                    dbContextOptionsBuilder
                        .LogTo(Console.WriteLine, LogLevel.Information)
                        .EnableSensitiveDataLogging();
                }
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
