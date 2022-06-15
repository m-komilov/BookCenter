using BookCenter.Data.Contexts;
using BookCenter.Data.IRepositories;
using BookCenter.Domain.Entities.Magazines;

namespace BookCenter.Data.Repositories
{
    public class MagazineRepository : GenericRepository<Magazine>, IMagazineRepository
    {
        public MagazineRepository(BookCenterDbContext context) : base(context)
        {

        }
    }
}
