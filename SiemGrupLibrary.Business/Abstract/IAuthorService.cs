using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiemGrupLibrary.Business.Dtos.AuthorDtos;
using SiemGrupLibrary.Entities.Entities;

namespace SiemGrupLibrary.Business.Abstract
{
    public interface IAuthorService
    {
        Task<List<GetAuthorDto>> GetAllAuthors();
        Task<GetAuthorDto> GetAuthorById(int id);
        Task<CreateAuthorDto> CreateAuthor(CreateAuthorDto authorDto);
        Task<UpdateAuthorDto> UpdateAuthor(int id,UpdateAuthorDto authorDto);
        Task DeleteAuthor(int id);
    }
}
