using BookCenter.Data.Contexts;
using BookCenter.Data.IRepositories;
using BookCenter.Domain.Entities.LocalizedBooks;

namespace BookCenter.Data.Repositories
{
    public class LocalizedBookRepository : GenericRepository<LocalizedBook>, ILocalizedBookRepository
    {
        public LocalizedBookRepository(BookCenterDbContext context) : base(context)
        {

        }
    }
}
