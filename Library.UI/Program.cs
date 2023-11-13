using Autofac;
using Library.DataLayer.Context;
using Library.DataLayer.Repositories.Concrete.EntityTypeRepository;
using Library.DataLayer.Repositories.Interfaces.EntityTypeRepository;
using Microsoft.EntityFrameworkCore;

namespace Library.UI
{
    internal static class Program
    {
        public static IContainer Container;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Container = Configure();
            Application.Run(new XtraHome(
                Container.Resolve<ICategoryRepository>()
                ));
        }

        static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Register DbContextOptions
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(@"Server=HP\SQLEXPRESS;Database=LibraryDb;Integrated Security=true");

            var dbContextOptions = optionsBuilder.Options;
            builder.RegisterInstance(dbContextOptions).As<DbContextOptions<ApplicationDbContext>>();

            // Register ApplicationDbContext
            builder.RegisterType<ApplicationDbContext>().AsSelf();

            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();

            builder.RegisterType<XtraHome>();
            return builder.Build();
        }
    }
}