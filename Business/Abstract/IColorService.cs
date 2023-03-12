using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        void Add(Color car);
        void Delete(Color car);
        void Update(Color car);
        Color GetById(int id);
        List<Color> GetAll(Expression<Func<Color, bool>> filter = null);
    }
}
