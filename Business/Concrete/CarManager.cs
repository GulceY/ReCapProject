using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities_.Concrete;
using Entities_.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public Result Add(Car car)
        {
            if (car.ModelYear<2000)
            {
                return new SuccessResult(Messages.CarError);
            }
            _carDal.Add(car);

            return new SuccessResult(Messages.CarAdded);
        }

        public Result Delete(Car car)
        {
            _carDal.Delete(car);

            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            var result = _carDal.GetCarDetails().ToList();

            return new SuccessDataResult<List<CarDetailDto>>(result,Messages.CarListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            var result = _carDal.GetAll(c => c.BrandId == brandId).ToList();
            return new SuccessDataResult<List<Car>>(result, Messages.CarListed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorid)
        {
            if (DateTime.Now.Hour ==23)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            var result =_carDal.GetAll(c => c.ColorId == colorid).ToList();

            return new ErrorDataResult<List<Car>>(result, Messages.CarListed);
        }

       
        public Result Update(Car car)
        { 
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
