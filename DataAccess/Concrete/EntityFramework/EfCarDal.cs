using Core.DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete.Database;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : IEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (var _context=new ReCapProjectContext())
            {
                return (from color in _context.Colors
                              join car in _context.Cars on color.Id equals car.ColorId
                              join brand in _context.Brands on car.BrandId equals brand.Id
                              select new CarDetailDto 
                              { 
                                CarId=car.Id,
                                CarName=car.Name,
                                ColorName=color.Name,
                                BrandName=brand.Name,
                                DailyPrice=car.DailyPrice
                              }).ToList();
            }
        }
    }
}
