using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCenter.Service.DTOs.Magazines
{
    public class MagazineForCreationDTO
    {
        public string? Title { get; set; }
        public string? Publisher { get; set; }
        public int ReleaseNumber { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
