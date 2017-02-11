using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCheckpoint.Models
{
    public interface ISearchRepository<T> where T : class
    {
        T GetById(int id);
    }
}
