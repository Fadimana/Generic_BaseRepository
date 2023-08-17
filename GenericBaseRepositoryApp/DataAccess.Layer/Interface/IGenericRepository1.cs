using DataAccess.Layer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Layer.Interface
{
    public interface IGenericRepository1<T> where T : BaseEntity
    {
        Task <List<T>> GetAll();
        Task<T>GetById(int id);
        Task<T> Create(T t);
        Task<T> Update(T t);

        Task DeleteById(int id);



    }
}
