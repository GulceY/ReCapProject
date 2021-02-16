using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entities_.Concrete;
using Entities_.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public Result Add(Rental rental)
        {
            if (rental.ReturnDate==null)
            {
                return new ErrorResult(Messages.RentalError);
            }
            _rentalDal.Add(rental);

            return new SuccessResult(Messages.CarAdded);
        }

        public Result Delete(Rental rental)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetCarsByCarId(int carId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetCarsByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            throw new NotImplementedException();
        }

        public Result Update(Rental rental)
        {
            throw new NotImplementedException();
        }
    }
}
