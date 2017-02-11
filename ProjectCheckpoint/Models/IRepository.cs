using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCheckpoint.Models
{
    public interface IRepository<T> : IDisposable where T : class
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
