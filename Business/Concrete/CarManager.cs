using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        public ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Name.Length > 2 && car.DailyPrice > 0)
                _carDal.Add(car);
            else
                Console.WriteLine(" Araba ismi minimum 2 karakter olmalı ve araba günlük fiyatı 0'dan büyük olmalıdır.");

        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            return _carDal.Get(filter);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _carDal.GetAll(filter);
        }

        public void Update(Car car)
        {
            if (car.Name.Length > 2 && car.DailyPrice > 0)
                _carDal.Update(car);
            else
                Console.WriteLine(" Araba ismi minimum 2 karakter olmalı ve araba günlük fiyatı 0'dan büyük olmalıdır.");

        }
    }
}
