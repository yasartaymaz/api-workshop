using ApiWorkshop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApiWorkshop.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);

        int Count(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

        T Add(T entity);

        T Modify(T entity);

        bool Delete(T entity);
    }
}
