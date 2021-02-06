using Entities_.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICar
    {
        List<Car> GetById(int Id);
        List<Car> GetAll();
        void Add(Car car);
        void UpDate(Car car);
        void Delete(int carId);
    }



}
