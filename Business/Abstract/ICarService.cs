using Core.Utilities;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities_.Concrete;
using Entities_.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorid);
        Result Add(Car car);
        Result Update(Car car);
        Result Delete(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();
       
    }
}
