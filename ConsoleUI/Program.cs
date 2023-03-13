using Business.Concrete;
using Core.Utilities.Results;
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


            #region /* Add Method Performed */

            //List<Brand> createdBrands = new() {
            //    new (){  Name = "TESLA" },
            //    new (){  Name = "FORD" },
            //    new (){  Name = "DACIA" },

            //};
            //// Add Brand
            //createdBrands.ForEach(createdBrand =>
            //{
            //        brandManager.Add(createdBrand);
            //});
            //List<Color> createdColors = new() {
            //    new (){  Name = "Orange" },
            //    new (){  Name = "Pale Sky" }
            //};
            //// Add Color
            //createdColors.ForEach(createdColor =>
            //{
            //    colorManager.Add(createdColor);
            //});
            List<Car> createdCars = new() {
                new (){  Name="n",BrandId = 4, ColorId = 2, ModelYear = 2019, DailyPrice =1000, Description = "Bu RENAULT clio aracıdır" },
                new Car(){ Name="TESLA", BrandId=1004,ColorId=1,ModelYear=2020,DailyPrice=18000,Description="Bu TESLA model 3 aracıdır" },
                new Car(){  Name="TESLA", BrandId=1004,ColorId=3,ModelYear=2015,DailyPrice=6100,Description="Bu TESLA Cybertruck aracıdır" },
                new Car(){  Name="RENAULT", BrandId=4,ColorId=2,ModelYear=2022,DailyPrice=1500,Description="Bu RENAULT clio aracıdır" }

            };
            // Add Car
            createdCars.ForEach(createdCar =>
            {
                carManager.Add(createdCar);
            });
            #endregion


            #region /* GetAll Method Performed */
            //// GetAll Brand
            //List<Brand> brands = brandManager.GetAll();
            //Console.WriteLine("brands length: " + brands.Count);
            //// GetAll Color
            //List<Color> colors = colorManager.GetAll();
            //Console.WriteLine("colors length: " + colors.Count);
            //// GetAll Car
            // 1- kullanım : IDataResult<List<Car>> cars = carManager.GetAll();
            List<Car> cars = carManager.GetAll().Data;
            Console.WriteLine("cars length: " + cars.Count);
            #endregion


            #region /* Delete Method Performed */
            ////Delete Brand
            //var brand = brands.Last();
            //brandManager.Delete(brand);
            //brands = brandManager.GetAll();
            //Console.WriteLine("brands length after deleted : " + brands.Count);
            ////Delete Color
            //var color = colors.Last();
            //colorManager.Delete(color);
            //colors = colorManager.GetAll();
            //Console.WriteLine("colors length after deleted : " + colors.Count);
            ////Delete Car
            var car = cars.First();
            carManager.Delete(car);
            cars = carManager.GetAll().Data;
            Console.WriteLine("cars length after deleted : " + cars.Count);
            #endregion


            #region /* GetById Method Performed */

            //// GetById Brand
            //brand = brands.Last();
            //Brand brandById = brandManager.GetById(brand.Id);
            //Console.WriteLine("brand Id - Name: " + brandById.Id + " - " + brandById.Name);
            //// GetById Color
            //color = colors.Last();
            //Color colorById = colorManager.GetById(color.Id);
            //Console.WriteLine("color Id - Name: " + colorById.Id + " - " + colorById.Name);
            //// GetById Car
            car = cars.Last();
            IDataResult<Car> carById = carManager.GetById(car.Id);
            Console.WriteLine("car Id - Description: " + carById.Data.Id + " - " + carById.Data.Description);
            #endregion


            #region /* Update Method Performed */

            //// Update Car
            //brandById.Name = "FERRARI";
            //brandManager.Update(brandById);
            //brandById = brandManager.GetById(brandById.Id);
            //Console.WriteLine("brandById  Id - Name after update: " + brandById.Id + " - " + brandById.Name);
            //// Update Car
            //colorById.Name = "YELLOW";
            //colorManager.Update(colorById);
            //colorById = colorManager.GetById(color.Id);
            //Console.WriteLine("colorById  Id - Nameafter update: " + colorById.Id + " - " + colorById.Name);
            //// Update Car
            carById.Data.Description = "Bu GÜNCELLENEN arabadır";
            carManager.Update(carById.Data);
            carById = carManager.GetById(car.Id);
            Console.WriteLine("carById  Id - Description after update: " + carById.Data.Id + " - " + carById.Data.Description);
            #endregion


            #region  /* GetCarDetails Method Performed */

            // 1- Yöntem : carManager.GetCarDetails().Data.ForEach(x => Console.WriteLine($"{x.CarId} - {x.CarName} - {x.ColorName} - {x.BrandName} - {x.DailyPrice}"));
            var result = carManager.GetCarDetails(); // 2. Yöntem.
            if (result.Success == true)
            {
                result.Data.ForEach(x => Console.WriteLine($"{x.CarId} - {x.CarName} - {x.ColorName} - {x.BrandName} - {x.DailyPrice}"));
            }

            #endregion
        }
    }
}