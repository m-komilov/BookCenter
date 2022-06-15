using BookCenter.Data.Contexts;
using BookCenter.Data.IRepositories;
using BookCenter.Domain.Entities.Books;

namespace BookCenter.Data.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(BookCenterDbContext context) : base(context)
        {

        }
    }
}
