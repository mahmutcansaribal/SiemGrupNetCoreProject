using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiemGrupLibrary.DataAccess.Context;
using SiemGrupLibrary.DataAccess.Repositories;
using SiemGrupLibrary.DataAccess.Repositories.Interfaces;
using SiemGrupLibrary.Entities.Entities;

namespace SiemGrupLibrary.DataAccess.EntityFramework
{
    public class EfAuthorDal : GenericRepository<Author>, IAuthorDal
    {
        public EfAuthorDal(LibraryContext libraryContext) : base(libraryContext)
        {
        }
    }
}
