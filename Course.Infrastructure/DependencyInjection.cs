using Course.Application.Interfaces;
using Course.Application.Services;
using Course.Domain.Interfaces;
using Course.Infrastructure.Data.Context;
using Course.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Course.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName));
            });

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ILessonRepository, LessonRepository>();
            services.AddScoped<IModuleRepository, ModuleRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<ICourseService, CourseService>();

            return services;
        }
    }
}