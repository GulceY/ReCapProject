
using Core.Entity;
using DataAccess.Abstract;
using Entities_.Concrete;
using Entities_.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                             join cl in context.Colors 
                             on c.ColorId equals cl.ColorId 
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto { CarId= c.CarId,ColorName = cl.ColorName, BrandName = b.BrandName,DailyPrice = c.DailyPrice };
                return result.ToList();
            }   
            
            
        }
    }
}

