using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class,IEntity,new()  
    {
        // InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazınız.

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T Get(Expression<Func<T,bool>> filter);
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
    }
}
