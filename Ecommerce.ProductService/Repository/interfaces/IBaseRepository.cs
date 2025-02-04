using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.Interface
{
    public interface IBaseRepository<T>
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task Delete(int id);
        Task Update(T entity);

    }
}
