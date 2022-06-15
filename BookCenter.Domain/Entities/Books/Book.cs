using BookCenter.Domain.Commons;
using BookCenter.Domain.Enums;

namespace BookCenter.Domain.Entities.Books
{
    public class Book : IAuditable
    {
        public Guid Id { get; set; }
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string? Authors { get; set; }
        public int NumberOfPages { get; set; }
        public string? Publisher { get; set; }
        public DateTime DatePublished { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
        public ItemState State { get; set; }

    }

}
