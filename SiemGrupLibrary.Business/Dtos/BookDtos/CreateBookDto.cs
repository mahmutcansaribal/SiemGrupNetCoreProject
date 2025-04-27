using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemGrupLibrary.Business.Dtos.BookDtos
{
    public class CreateBookDto
    {
        [Required(ErrorMessage = "Kitap başlığı boş geçilemez.")]
        [MaxLength(200, ErrorMessage = "Kitap başlığı 100 karakterden fazla olamaz.")]
        public string BookTitle { get; set; }
        [Required(ErrorMessage = "Kitap yayınlanma tarihi boş geçilemez.")]
        [Range(1, int.MaxValue, ErrorMessage = "Kitabın yayınlandığı tarih 0'dan küçük olamaz.")]
        public int BookPublishedYear { get; set; }
        [Required(ErrorMessage = "Kitap ücreti boş geçilemez.")]
        [Range(0, double.MaxValue, ErrorMessage = "Fiyat 0'dan küçük olamaz..")]
        public decimal BookPrice { get; set; }
        [Required(ErrorMessage ="Yazar ID boş geçilemez.")]
        public int AuthorID { get; set; }
    }
}
