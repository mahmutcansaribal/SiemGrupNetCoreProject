using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemGrupLibrary.Business.Dtos.AuthorDtos
{
    public class GetAuthorDto
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
