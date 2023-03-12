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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color car)
        {
            _colorDal.Add(car);
        }

        public void Delete(Color car)
        {
            _colorDal.Delete(car);
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
           return _colorDal.Get(filter);
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            return _colorDal.GetAll(filter);   
        }

        public void Update(Color car)
        {
            _colorDal.Update(car);
        }
    }
}
