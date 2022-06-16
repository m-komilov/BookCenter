﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCenter.Service.DTOs.Books
{
    public class BookForCreationDTO
    {
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string? Authors { get; set; }
        public int NumberOfPages { get; set; }
        public string? Publisher { get; set; }
        public DateTime DatePublished { get; set; }
    }
}