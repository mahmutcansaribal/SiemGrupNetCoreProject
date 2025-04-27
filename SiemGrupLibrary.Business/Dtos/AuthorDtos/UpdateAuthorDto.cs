using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemGrupLibrary.Business.Dtos.AuthorDtos
{
    public class UpdateAuthorDto
    {
        // public int AuthorID { get; set; }
        [Required(ErrorMessage = "Yazar ismi boş geçilemez.")]
        [MaxLength(100, ErrorMessage = "Yazar ismi 100 karakterden fazla olamaz.")]
        public string AuthorName { get; set; }
        [Required(ErrorMessage = "Doğum tarihi boş geçilemez.")]
        public DateTime BirthDate { get; set; }
    }
}
