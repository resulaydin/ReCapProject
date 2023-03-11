using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());


           
            // In Memory alanında toplam 4 adet ekli halde bulunduğundan dolayı Id=5 olacak şekilde araç eklendi. 
            // Default olarak araç belirlemeyip buradan sıfırdan araç eklemesi yapılabilmektedir.
            Car car = new Car() {Id=5, BrandId = 5, ColorId = 5, ModelYear = 2019, DailyPrice = 900, Description = "Bu TOGG aracıdır" };
          
            // GetAll Car
            List<Car> cars = carManager.GetAll();
            Console.WriteLine("cars length: " + cars.Count);

            // Add Car
            carManager.Add(car);
            cars = carManager.GetAll();
            Console.WriteLine("cars length: "+cars.Count);

            //Delete Car
            car=cars.Last();
            carManager.Delete(car);
            cars = carManager.GetAll();
            Console.WriteLine("cars length: " + cars.Count);

            // GetById Car
            Car getFirstCar = carManager.GetById(cars.FirstOrDefault().Id);
            Console.WriteLine("cars Id - Description: "+getFirstCar.Id+" - "+ getFirstCar.Description);

            // Update Car
            getFirstCar.Description = "Bu GÜNCELLENEN arabadır";
            carManager.Update(getFirstCar);
            Console.WriteLine("cars  Id - Description: "+ getFirstCar.Id + " - " + getFirstCar.Description);


        }
    }
}