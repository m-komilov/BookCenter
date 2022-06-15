using BookCenter.Domain.Commons;
using BookCenter.Domain.Enums;

namespace BookCenter.Domain.Entities.Magazines
{
    public class Magazine : IAuditable
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Publisher { get; set; }
        public int ReleaseNumber { get; set; }
        public DateTime PublishDate { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
        public ItemState State { get; set; }
    }
}
