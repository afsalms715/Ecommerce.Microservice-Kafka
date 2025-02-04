using Ecommerce.Models.Interface;
using Microsoft.EntityFrameworkCore;
using Ecommerce.ProductService.Data;

namespace Ecommerce.Models.General
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private readonly ProductDbContext Context;
        public BaseRepository(ProductDbContext context)
        {
            Context = context;
        }
        public virtual async Task Delete(int id)
        {
            var entiy = await Get(id);
            Context.Set<T>().Remove(entiy);
        }

        public virtual async Task<T> Get(int id)
        {
            return await Context.Set<T>().FirstAsync(x => x.Id == id);
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await Context.Set<T>().ToListAsync();
        }

        public virtual async Task Update(T entity)
        {
            Context.Update(entity);
        }
    }
}
