using Autofac;
using Library.BusinessLayer.Abstract;
using Library.BusinessLayer.Concrete;
using Library.DataLayer.Context;
using Library.DataLayer.Repositories.Concrete.EntityTypeRepository;
using Library.DataLayer.Repositories.Interfaces.EntityTypeRepository;
using Microsoft.EntityFrameworkCore;

namespace Library.UI
{
    internal static class Program
    {
        public static IContainer Container;
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Container = Configure();
            Application.Run(new XtraHome(
                Container.Resolve<IAuthorService>(),
                Container.Resolve<IBookService>(),
                Container.Resolve<ICategoryService>(),
                Container.Resolve<IEmailService>(),
                Container.Resolve<IMemberService>(),
                Container.Resolve<IPublishingHouseService>(),
                Container.Resolve<ApplicationDbContext>()
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

            builder.RegisterType<AuthorManager>().As<IAuthorService>();
            builder.RegisterType<AuthorRepository>().As<IAuthorRepository>();

            builder.RegisterType<BookManager>().As<IBookService>();
            builder.RegisterType<BookRepository>().As<IBookRepository>();

            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();

            builder.RegisterType<EmailManager>().As<IEmailService>();
            builder.RegisterType<EmailRepository>().As<IEmailRepository>();

            builder.RegisterType<MemberManager>().As<IMemberService>();
            builder.RegisterType<MemberRepository>().As<IMemberRepository>();

            builder.RegisterType<PublishingHouseManager>().As<IPublishingHouseService>();
            builder.RegisterType<PublishingHouseRepository>().As<IPublishingHouseRepository>();

            builder.RegisterType<XtraHome>();

            return builder.Build();
        }
    }
}