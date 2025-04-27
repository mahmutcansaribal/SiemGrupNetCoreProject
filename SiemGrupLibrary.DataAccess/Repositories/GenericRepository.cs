using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SiemGrupLibrary.DataAccess.Context;
using SiemGrupLibrary.DataAccess.Repositories.Interfaces;

namespace SiemGrupLibrary.DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly LibraryContext _libraryContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
            _dbSet = libraryContext.Set<T>();
        }

        public async Task<T> Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _libraryContext.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(T entity)
        {
            _dbSet.Remove(entity);
            await _libraryContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> Update(T entity)
        {
            _dbSet.Update(entity);
            await _libraryContext.SaveChangesAsync();
            return entity;
        }
    }
}
