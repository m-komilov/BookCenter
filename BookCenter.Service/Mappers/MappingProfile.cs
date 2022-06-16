using AutoMapper;
using BookCenter.Domain.Entities.Books;
using BookCenter.Domain.Entities.LocalizedBooks;
using BookCenter.Domain.Entities.Magazines;
using BookCenter.Domain.Entities.Patents;
using BookCenter.Service.DTOs.Books;
using BookCenter.Service.DTOs.LocalizedBooks;
using BookCenter.Service.DTOs.Magazines;
using BookCenter.Service.DTOs.Patents;

namespace BookCenter.Service.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BookForCreationDTO, Book>().ReverseMap();

            CreateMap<LocalizedBookForCreationDTO, LocalizedBook>().ReverseMap();

            CreateMap<MagazineForCreationDTO, Magazine>().ReverseMap();

            CreateMap<PatentsForCreationDTO, Patent>().ReverseMap();
        }
    }
}
