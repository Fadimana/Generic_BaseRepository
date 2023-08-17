using Business.Layer.Interface;
using DataAccess.Layer.Entity;
using DataAccess.Layer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.Contrete
{
    public class GenericBusiness<T> : IGenericBusiness<T> where T : BaseEntity
    {
        private readonly IGenericRepository1<T> _genericRepository;

        public GenericBusiness(IGenericRepository1<T> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<T> Create(T t)
        {    
            if (t != null) {
                return await _genericRepository.Create(t);
            }
            throw new Exception("Boş bırakma!");
        }

        public  Task DeleteById(int id)
        { 
           return   _genericRepository.DeleteById(id);
        }

        public async Task<List<T>> GetAll()
        {
            return await _genericRepository.GetAll();
        }

        public async Task<T> GetById(int id)
        {
            return await _genericRepository.GetById(id);
        }

        public async Task<T> Update(T t)
        {
            return await _genericRepository.Update(t);
        }
    }
}
