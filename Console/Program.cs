using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities_.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager cars = new CarManager(new EfCarDal());
            foreach (var car in cars.GetCarsByBrandId(3))
            {
                System.Console.WriteLine(car.CarId);
            }



        }
    }
}
