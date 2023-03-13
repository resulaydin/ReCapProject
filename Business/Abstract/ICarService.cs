using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
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
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetAll(Expression<Func<Car, bool>> filter=null);
        IDataResult<List<CarDetailDto>> GetCarDetails();


        #region Before IResult

        //void Add(Car car);
        //void Delete(Car car);
        //void Update(Car car);
        //Car GetById(int id);
        //List<Car> GetAll(Expression<Func<Car, bool>> filter = null);
        //List<CarDetailDto> GetCarDetails(); 
        #endregion
    }
}
