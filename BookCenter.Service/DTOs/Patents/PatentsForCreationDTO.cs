namespace BookCenter.Service.DTOs.Patents
{
    public class PatentsForCreationDTO
    {
        public string? Title { get; set; }
        public string? Authors { get; set; }
        public DateTime DatePublished { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
