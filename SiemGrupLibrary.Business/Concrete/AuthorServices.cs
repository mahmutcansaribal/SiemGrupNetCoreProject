using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SiemGrupLibrary.Business.Abstract;
using SiemGrupLibrary.Business.Dtos.AuthorDtos;
using SiemGrupLibrary.DataAccess.Repositories.Interfaces;
using SiemGrupLibrary.Entities.Entities;

namespace SiemGrupLibrary.Business.Concrete
{
    public class AuthorServices : IAuthorService
    {
        private readonly IAuthorDal _authorDal;
        private readonly IMapper _mapper;

        public AuthorServices(IAuthorDal authorDal, IMapper mapper)
        {
            _authorDal = authorDal;
            _mapper = mapper;
        }

        public async Task<CreateAuthorDto> CreateAuthor(CreateAuthorDto authorDto)
        {
            var author = _mapper.Map<Author>(authorDto);
            var createdAuthor = await _authorDal.Add(author);
            return _mapper.Map<CreateAuthorDto>(createdAuthor);
        }

        public async Task DeleteAuthor(int id)
        {
            var author = await _authorDal.GetById(id);
            if (author.Books != null && author.Books.Any())
            {
                throw new Exception("Kitapları olan bir yazarı silemezsiniz.");
            }
            await _authorDal.Delete(author);
        }

        public async Task<List<GetAuthorDto>> GetAllAuthors()
        {
            var authors = await _authorDal.GetAll();
            return _mapper.Map<List<GetAuthorDto>>(authors);
        }

        public async Task<GetAuthorDto> GetAuthorById(int id)
        {
            var author = await _authorDal.GetById(id);
            return _mapper.Map<GetAuthorDto>(author);
        }

        public async Task<UpdateAuthorDto> UpdateAuthor(int id,UpdateAuthorDto authorDto)
        {
            var author = await _authorDal.GetById(id);
            _mapper.Map(authorDto, author);
            var updateAuthor = await _authorDal.Update(author);
            return _mapper.Map<UpdateAuthorDto>(updateAuthor);
        }
    }
}
