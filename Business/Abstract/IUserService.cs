using Core.Utilities;
using Entities_.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
       
        Result Add(User user);
        Result Delete(User user);
        IDataResult<List<User>> GetAll();
        
    }
}
