using BookCenter.Data.Contexts;
using BookCenter.Data.IRepositories;

namespace BookCenter.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BookCenterDbContext context;

        /// <summary>
        /// Repositories
        /// </summary>
        public IBookRepository Books { get; set; }

        public ILocalizedBookRepository LocalizedBooks { get; set; }

        public IMagazineRepository Magazines { get; set; }

        public IPatentRepository Patents { get; set; }

        public UnitOfWork(BookCenterDbContext context)
        {
            this.context = context;

            // Object initializing for repositories
            Books = new BookRepository(context);
            LocalizedBooks = new LocalizedBookRepository(context);
            Magazines = new MagazineRepository(context);
            Patents = new PatentRepository(context);

        }

        /// <summary>
        /// Run Garbage Collector this File
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// saved all changes
        /// </summary>
        /// <returns></returns>
        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
