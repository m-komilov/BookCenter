namespace BookCenter.Data.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository Books { get; }
        ILocalizedBookRepository LocalizedBooks { get; }
        IMagazineRepository Magazines { get; }
        IPatentRepository Patents { get; }

        Task SaveChangeAsync();
    }
}
