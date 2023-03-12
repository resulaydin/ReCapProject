using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        Car Get(Expression<Func<Car,bool>> filter);
        List<Car> GetAll(Expression<Func<Car, bool>> filter=null);
    }
}
