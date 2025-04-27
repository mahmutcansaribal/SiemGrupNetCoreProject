using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiemGrupLibrary.Business.Dtos.BookDtos;

namespace SiemGrupLibrary.Business.Abstract
{
    public interface IBookService
    {
        Task<List<GetBookDto>> GetAllBooks();
        Task<GetBookDto> GetBookById(int id);
        Task<CreateBookDto> CreateBook(CreateBookDto createBookDto);
        Task<UpdateBookDto> UpdateBook(int id,UpdateBookDto updateBookDto);
        Task DeleteBook(int id);
    }
}
