using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entities_.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public Result Add(User user)
        {
           
            _userDal.Add(user);

            return new SuccessResult(Messages.UserAdded);
        }

        public Result Delete(User user)
        {
            _userDal.Delete(user);

            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            var result =_userDal.GetAll().ToList();

            return new SuccessDataResult<List<User>>(result, Messages.UserListed);
        }
    }
}
