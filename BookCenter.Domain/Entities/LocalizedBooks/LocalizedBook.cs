using BookCenter.Domain.Commons;
using BookCenter.Domain.Enums;

namespace BookCenter.Domain.Entities.LocalizedBooks
{
    public class LocalizedBook : IAuditable
    {
        public Guid Id { get; set; }
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string? Authors { get; set; }
        public int NumberOfPages { get; set; }
        public string? OriginalPublisher { get; set; }
        public string? CountryOfLocalization { get; set; }
        public string? LocalPublisher { get; set; }
        public DateTime DatePublished { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
        public ItemState State { get; set; }

        public void Update()
        {
            UpdatedAt = DateTime.Now;
            State = ItemState.Updated;
        }

        public void Create()
        {
            CreatedAt = DateTime.Now;
            State = ItemState.Created;
        }

        public void Delete()
        {
            State = ItemState.Deleted;
        }
    }
}
