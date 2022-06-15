using BookCenter.Data.Contexts;
using BookCenter.Data.IRepositories;
using BookCenter.Domain.Entities.Patents;

namespace BookCenter.Data.Repositories
{
    public class PatentRepository : GenericRepository<Patent>, IPatentRepository
    {
        public PatentRepository(BookCenterDbContext context) : base(context)
        {

        }
    }
}
