using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car(){ Id=1, BrandId=1,ColorId=1,ModelYear=2000,DailyPrice=500,Description="Bu BMW aracıdır" },
                new Car(){ Id=2, BrandId=2,ColorId=2,ModelYear=2005,DailyPrice=600,Description="Bu AUDI aracıdır" },
                new Car(){ Id=3, BrandId=3,ColorId=3,ModelYear=2009,DailyPrice=700,Description="Bu MERCEDES aracıdır" },
                new Car(){ Id=4, BrandId=4,ColorId=4,ModelYear=2013,DailyPrice=800,Description="Bu GOLF aracıdır" }
            
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car); 
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id)!;
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int Id)
        {
            return _cars.SingleOrDefault(car => car.Id == Id)!;
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id)!;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.ColorId=car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
