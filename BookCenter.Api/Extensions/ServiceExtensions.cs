using BookCenter.Data.IRepositories;
using BookCenter.Data.Repositories;

namespace BookCenter.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<ILocalizedBookRepository, LocalizedBookRepository>();
            services.AddScoped<IMagazineRepository, MagazineRepository>();
            services.AddScoped<IPatentRepository, PatentRepository>();
        }
    }
}
