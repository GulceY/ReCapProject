using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities_.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorid);
    }
}
