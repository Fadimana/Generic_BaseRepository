using DataAccess.Layer.Entity;
using DataAccess.Layer.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Layer.Contrete
{
    public class GenericRepository <T> : IGenericRepository1<T> where T : BaseEntity
    {
        private readonly AppDbContext _appDbContext;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<T> Create(T t)
        {   
            await _appDbContext.Set<T>().AddAsync(t);
            await _appDbContext.SaveChangesAsync();
            return t;
        }

        public async Task DeleteById(int id)
        {
            var a= await _appDbContext.Set<T>().FindAsync(id);
            _appDbContext.Set<T>().Remove(a);
            await _appDbContext.SaveChangesAsync();

        }

        public async Task<List<T>> GetAll()
        {
            return await _appDbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _appDbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<T> Update(T t)
        {
             _appDbContext.Set<T>().Update(t);
            await _appDbContext.SaveChangesAsync();
            return t;
        }
    }
}
