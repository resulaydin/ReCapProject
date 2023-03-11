using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        // InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazınız.

        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        Car GetById(int Id);
        List<Car> GetAll();


    }
}
