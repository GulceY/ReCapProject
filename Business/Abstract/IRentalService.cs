using Core.Utilities;
using Entities_.Concrete;
using Entities_.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetCarsByCarId(int carId);
        IDataResult<List<Rental>> GetCarsByCustomerId(int customerId);
        Result Add(Rental rental);
        Result Update(Rental rental);
        Result Delete(Rental rental);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
    }
}
