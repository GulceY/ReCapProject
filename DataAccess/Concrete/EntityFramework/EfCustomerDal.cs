using Core.Entity;
using DataAccess.Abstract;
using Entities_.Concrete;
using Entities_.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCapContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetailDtos()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Customers
                             join u in context.Users
                             on c.UseId equals u.Id
                             select new CustomerDetailDto 
                             { 
                                 UserId =u.Id,
                                 CompanyName=c.CompanyName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Password =u.Password,
                                 Email=u.Email,
                                 
                             
                             
                             };

                return result.ToList();
            }
        }
    }
}
