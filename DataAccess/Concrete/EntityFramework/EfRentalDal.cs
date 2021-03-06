﻿using Core.Entity;
using DataAccess.Abstract;
using Entities_.Concrete;
using Entities_.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetailDtos()
        {
            using (ReCapContext context =new ReCapContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.CarId
                             join cu in context.Customers
                             on r.CustomerId equals cu.UseId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new RentalDetailDto { 

                                 Id=r.Id,
                                 CarName = b.BrandName, 
                                 CompanyName = cu.CompanyName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                                 
                             };


                return result.ToList();

            } 
        }
    }
}
