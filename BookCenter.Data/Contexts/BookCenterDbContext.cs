using BookCenter.Domain.Entities.Books;
using BookCenter.Domain.Entities.LocalizedBooks;
using BookCenter.Domain.Entities.Magazines;
using BookCenter.Domain.Entities.Patents;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

#pragma warning disable
namespace BookCenter.Data.Contexts
{
    public class BookCenterDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public BookCenterDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<LocalizedBook> LocalizedBooks { get; set; }
        public virtual DbSet<Patent> Patents { get; set; }
        public virtual DbSet<Magazine> Magazines { get; set; }
    }
}
