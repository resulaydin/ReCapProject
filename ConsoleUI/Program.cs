﻿using Business.Concrete;
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

            List<Brand> createdBrands = new() {
                new (){  Name = "RENAULT" },
                new (){  Name = "FORD" },
                new (){  Name = "DACIA" },

            };
            // Add Brand
            createdBrands.ForEach(createdBrand =>
            {
                brandManager.Add(createdBrand);
            });
            List<Color> createdColors = new() {
                new (){  Name = "Orange" },
                new (){  Name = "Pale Sky" }
            };
            // Add Color
            createdColors.ForEach(createdColor =>
            {
                colorManager.Add(createdColor);
            });
            List<Car> createdCars = new() {
                new (){  Name="RENAULT",BrandId = 4, ColorId = 2, ModelYear = 2019, DailyPrice =1000, Description = "Bu RENAULT clio aracıdır" },
                new Car(){ Name="FORD", BrandId=5,ColorId=3,ModelYear=2010,DailyPrice=5100,Description="Bu FORD musteng aracıdır" },
                new Car(){  Name="FORD", BrandId=5,ColorId=4,ModelYear=2015,DailyPrice=6100,Description="Bu FORD focus aracıdır" },
                new Car(){  Name="DACIA", BrandId=6,ColorId=2,ModelYear=2012,DailyPrice=1500,Description="Bu DACIA Sandero aracıdır" }

            };
            // Add Car
            createdCars.ForEach(createdCar =>
            {
                carManager.Add(createdCar);
            });
            #endregion


            #region /* GetAll Method Performed */
            // GetAll Brand
            List<Brand> brands = brandManager.GetAll();
            Console.WriteLine("brands length: " + brands.Count);
            // GetAll Color
            List<Color> colors = colorManager.GetAll();
            Console.WriteLine("colors length: " + colors.Count);
            // GetAll Car
            List<Car> cars = carManager.GetAll();
            Console.WriteLine("cars length: " + cars.Count);
            #endregion


            #region /* Delete Method Performed */
            //Delete Brand
            var brand = brands.Last();
            brandManager.Delete(brand);
            brands = brandManager.GetAll();
            Console.WriteLine("brands length after deleted : " + brands.Count);
            //Delete Color
            var color = colors.Last();
            colorManager.Delete(color);
            colors = colorManager.GetAll();
            Console.WriteLine("colors length after deleted : " + colors.Count);
            //Delete Car
            var car = cars.First();
            carManager.Delete(car);
            cars = carManager.GetAll();
            Console.WriteLine("cars length after deleted : " + cars.Count);
            #endregion


            #region /* GetById Method Performed */

            // GetById Brand
            brand = brands.Last();
            Brand brandById = brandManager.GetById(brand.Id);
            Console.WriteLine("brand Id - Name: " + brandById.Id + " - " + brandById.Name);
            // GetById Color
            color = colors.Last();
            Color colorById = colorManager.GetById(color.Id);
            Console.WriteLine("color Id - Name: " + colorById.Id + " - " + colorById.Name);
            // GetById Car
            car = cars.Last();
            Car carById = carManager.GetById(car.Id);
            Console.WriteLine("car Id - Description: " + carById.Id + " - " + carById.Description);
            #endregion


            #region /* Update Method Performed */

            // Update Car
            brandById.Name = "FERRARI";
            brandManager.Update(brandById);
            brandById = brandManager.GetById(brandById.Id);
            Console.WriteLine("brandById  Id - Name after update: " + brandById.Id + " - " + brandById.Name);
            // Update Car
            colorById.Name = "YELLOW";
            colorManager.Update(colorById);
            colorById = colorManager.GetById(color.Id);
            Console.WriteLine("colorById  Id - Nameafter update: " + colorById.Id + " - " + colorById.Name);
            // Update Car
            carById.Description = "Bu GÜNCELLENEN arabadır";
            carManager.Update(carById);
            carById = carManager.GetById(car.Id);
            Console.WriteLine("carById  Id - Description after update: " + carById.Id + " - " + carById.Description);
            #endregion


            #region  /* GetCarDetails Method Performed */

            carManager.GetCarDetails().ForEach(x => Console.WriteLine($"{x.CarId} - {x.CarName} - {x.ColorName} - {x.BrandName} - {x.DailyPrice}"));
            #endregion


        }
    }
}