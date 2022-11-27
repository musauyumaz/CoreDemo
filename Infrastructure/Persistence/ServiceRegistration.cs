using Application.Repositories.AboutRepository;
using Application.Repositories.BlogRepository;
using Application.Repositories.CategoryRepository;
using Application.Repositories.CommentRepository;
using Application.Repositories.ContactRepository;
using Application.Repositories.WriterRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Configurations;
using Persistence.Contexts;
using Persistence.Repositories.AboutRepository;
using Persistence.Repositories.BlogRepository;
using Persistence.Repositories.CategoryRepository;
using Persistence.Repositories.CommentRepository;
using Persistence.Repositories.ContactRepository;
using Persistence.Repositories.WriterRepository;

namespace Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<BlogDemoDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddScoped<IAboutReadRepository, AboutReadRepository>();
            services.AddScoped<IAboutWriteRepository, AboutWriteRepository>();
            services.AddScoped<IBlogReadRepository, BlogReadRepository>();
            services.AddScoped<IBlogWriteRepository, BlogWriteRepository>();
            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();
            services.AddScoped<ICommentReadRepository, CommentReadRepository>();
            services.AddScoped<ICommentWriteRepository, CommentWriteRepository>();
            services.AddScoped<IContactReadRepository, ContactReadRepository>();
            services.AddScoped<IContactWriteRepository, ContactWriteRepository>();
            services.AddScoped<IWriterReadRepository, WriterReadRepository>();
            services.AddScoped<IWriterWriteRepository, WriterWriteRepository>();
        }
    }
}
