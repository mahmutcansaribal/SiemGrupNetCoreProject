using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SiemGrupLibrary.Business.Abstract;
using SiemGrupLibrary.Business.Dtos.BookDtos;
using SiemGrupLibrary.DataAccess.Repositories.Interfaces;
using SiemGrupLibrary.Entities.Entities;

namespace SiemGrupLibrary.Business.Concrete
{
    public class BookServices : IBookService
    {
        private readonly IBookDal _bookDal;
        private readonly IMapper _mapper;

        public BookServices(IBookDal bookDal, IMapper mapper)
        {
            _bookDal = bookDal;
            _mapper = mapper;
        }

        public async Task<List<GetBookDto>> GetAllBooks()
        {
            var books = await _bookDal.GetAll();
            return _mapper.Map<List<GetBookDto>>(books);
        }

        public async Task<GetBookDto> GetBookById(int id)
        {
            var book = await _bookDal.GetById(id);
            return _mapper.Map<GetBookDto>(book);
        }

        public async Task<CreateBookDto> CreateBook(CreateBookDto createBookDto)
        {
            var book = _mapper.Map<Book>(createBookDto);
            var createdBook = await _bookDal.Add(book);
            return _mapper.Map<CreateBookDto>(createdBook);
        }

        public async Task<UpdateBookDto> UpdateBook(int id, UpdateBookDto updateBookDto)
        {
            var book = await _bookDal.GetById(id);
            _mapper.Map(updateBookDto, book); 
            var updateBook = await _bookDal.Update(book);
            return _mapper.Map<UpdateBookDto>(updateBook);
        }
        public async Task DeleteBook(int id)
        {
            var book = await _bookDal.GetById(id);
            await _bookDal.Delete(book);
        }
    }
}
