using OnlineSinav.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinav.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<T> GenericRepository<T>() where T : class;
        void Save();
    }
}
