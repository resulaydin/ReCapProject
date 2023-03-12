using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());


            List<Brand> createdBrands = new() {
                new (){  Name = "TOGG" },
                new (){  Name = "BMW" },
                new (){  Name = "AUDI" },

            };

            createdBrands.ForEach(createdBrand =>
            {
                brandManager.Add(createdBrand);
            });

            List<Color> createdColors = new() {
                new (){  Name = "Blue" },
                new (){  Name = "Green" }
            };

            createdColors.ForEach(createdColor =>
            {
                colorManager.Add(createdColor);
            });

            List<Car> createdCars = new() {
                new (){  Name="TOGG",BrandId = 3, ColorId = 2, ModelYear = 2019, DailyPrice = 900, Description = "Bu TOGG C1 aracıdır" },
                new Car(){ Name="BMW", BrandId=1,ColorId=1,ModelYear=2000,DailyPrice=500,Description="Bu BMW aracıdır" },
                new Car(){  Name="AUDI", BrandId=2,ColorId=1,ModelYear=2005,DailyPrice=600,Description="Bu AUDI aracıdır" },
                new Car(){  Name="AUDI", BrandId=2,ColorId=2,ModelYear=2012,DailyPrice=8500,Description="Bu AUDI aracıdır" }

            };


            // Add Car
            createdCars.ForEach(createdCar =>
            {
                carManager.Add(createdCar);
            });



            // GetAll Car
            List<Car> cars = carManager.GetAll();
            Console.WriteLine("cars length: " + cars.Count);

            
            cars = carManager.GetAll();
            Console.WriteLine("cars length: " + cars.Count);

            //Delete Car
            var car = cars.Last();
            carManager.Delete(car);
            cars = carManager.GetAll();
            Console.WriteLine("cars length: " + cars.Count);

            // GetById Car
            Car getFirstCar = carManager.Get(p => p.Id == cars.FirstOrDefault().Id);
            Console.WriteLine("cars Id - Description: " + getFirstCar.Id + " - " + getFirstCar.Description);

            // Update Car
            getFirstCar.Description = "Bu GÜNCELLENEN arabadır";
            carManager.Update(getFirstCar);
            Console.WriteLine("cars  Id - Description: " + getFirstCar.Id + " - " + getFirstCar.Description);


        }
    }
}