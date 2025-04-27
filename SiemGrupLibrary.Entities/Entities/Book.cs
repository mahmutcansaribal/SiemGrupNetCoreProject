using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemGrupLibrary.Entities.Entities
{
    public class Book
    {
        public int BookID { get; set; }
        [Required]
        [MaxLength(200,ErrorMessage ="Kitap başlığı boş geçilemez.")]
        public string BookTitle { get; set; }
        [Required]
        [Range(1, int.MaxValue,ErrorMessage ="Kitabın yayınlandığı tarih 0'dan küçük olamaz.")]
        public int BookPublishedYear { get; set; }
        [Required(ErrorMessage ="Fiyat boş geçilemez.")]
        [Range(0, double.MaxValue,ErrorMessage ="Fiyat 0'dan küçük olamaz.")]
        public decimal BookPrice { get; set; }
        [Required(ErrorMessage = "Yazar ID boş geçilemez.")]
        public int AuthorID { get; set; }
        public Author Author { get; set; }
    }
}
