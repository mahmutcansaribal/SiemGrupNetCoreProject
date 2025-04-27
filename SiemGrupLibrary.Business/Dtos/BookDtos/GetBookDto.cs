using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemGrupLibrary.Business.Dtos.BookDtos
{
    public class GetBookDto
    {
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public int BookPublishedYear { get; set; }
        public decimal BookPrice { get; set; }
        public int AuthorID { get; set; }
    }
}
