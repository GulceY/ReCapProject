using Core.Entity;
using DataAccess.Abstract;
using Entities_.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User,ReCapContext>, IUserDal
    {

    }
}
