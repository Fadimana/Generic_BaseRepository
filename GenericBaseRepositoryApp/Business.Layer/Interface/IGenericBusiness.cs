using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.Interface
{
    public interface IGenericBusiness<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Create(T t);
        Task<T> Update(T t);

        Task DeleteById(int id);

    }
}
