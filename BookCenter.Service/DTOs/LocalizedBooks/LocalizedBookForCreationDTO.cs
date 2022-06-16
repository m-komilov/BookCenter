﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCenter.Service.DTOs.LocalizedBooks
{
    public class LocalizedBookForCreationDTO
    {
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string? Authors { get; set; }
        public int NumberOfPages { get; set; }
        public string? OriginalPublisher { get; set; }
        public string? CountryOfLocalization { get; set; }
        public string? LocalPublisher { get; set; }
        public DateTime DatePublished { get; set; }
    }
}
