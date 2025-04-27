using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiemGrupLibrary.Business.Abstract;
using SiemGrupLibrary.Business.Concrete;
using SiemGrupLibrary.Business.Dtos.AuthorDtos;

namespace SiemGrupLibraryManagementProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public AuthorController(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAuthors()
        {
            var authors = await _authorService.GetAllAuthors();
            return Ok(_mapper.Map<List<GetAuthorDto>>(authors));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthorById(int id)
        {
            var author = await _authorService.GetAuthorById(id);
            if (author == null)
                return NotFound("Yazar bulunamadı");
            return Ok(author);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAuthor(CreateAuthorDto createAuthorDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _authorService.CreateAuthor(createAuthorDto);
            return Ok("Yazar eklendi");
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAuthor(UpdateAuthorDto updateAuthorDto, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _authorService.UpdateAuthor(id,updateAuthorDto);
            return Ok("Güncelleme işlemi başarılı");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            try
            {
                await _authorService.DeleteAuthor(id);
                return Ok("Silme işlemi başarılı");
            }
            catch (Exception ex)
            {
                return BadRequest("Kitabı olan bir yazarı silemezsiniz!");
            }
        }
    }
}
