using Ecommerce.ProductService.Data;
using Ecommerce.ProductService.Repository.interfaces;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.ProductService.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ProductDbContext _dbContext;

        private bool _disposed;
        public UnitOfWork(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Commit()
        {
            _dbContext.SaveChanges();
        }
        public void Rollback()
        {
            foreach (var entry in _dbContext.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                }
            }
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
