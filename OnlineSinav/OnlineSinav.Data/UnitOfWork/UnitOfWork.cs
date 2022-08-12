using OnlineSinav.Data.Data;
using OnlineSinav.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinav.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly OnlineSinavDBContext _context = null;

        public UnitOfWork(OnlineSinavDBContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {

            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

            }
            this.disposed = true;

        }
        public IGenericRepository<T> GenericRepository<T>() where T : class
        {
            GenericRepository<T> repo = new GenericRepository<T>(_context);
            return repo;    
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
