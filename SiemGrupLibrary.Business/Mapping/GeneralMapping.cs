using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SiemGrupLibrary.Business.Dtos.AuthorDtos;
using SiemGrupLibrary.Business.Dtos.BookDtos;
using SiemGrupLibrary.Entities.Entities;

namespace SiemGrupLibrary.Business.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Author, CreateAuthorDto>().ReverseMap();
            CreateMap<Author, UpdateAuthorDto>().ReverseMap();
            CreateMap<Author, GetAuthorDto>().ReverseMap();

            CreateMap<Book,CreateBookDto>().ReverseMap();
            CreateMap<Book,UpdateBookDto>().ReverseMap();
            CreateMap<Book,GetBookDto>().ReverseMap();
        }
    }
}
