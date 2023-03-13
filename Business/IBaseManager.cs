using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IBaseManager<T> where T : class, IEntity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
