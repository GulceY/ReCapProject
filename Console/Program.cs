﻿using Business.Concrete;
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
            //AddCarTest();
            //CarGetDetailsTest();
            UserTest();
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.Add(new User { FirstName = "Gülce", LastName = "Yılmaz", Email = "gulceyilmaz00@gmail.com", Password = "1234GY" });
            System.Console.WriteLine(result.Message);
        }

        private static void CarGetDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails().Data;
            foreach (var car in result)
            {
                System.Console.WriteLine(car.CarId + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            }
        }

        private static void AddCarTest()
        {
            CarManager cars = new CarManager(new EfCarDal());
            var result = cars.Add(new Car { BrandId = 3, ColorId = 2, DailyPrice = 300, ModelYear = 2004 });
            if (result.Success == true)
            {
                System.Console.WriteLine(result.Message);

            }
            else
            {
                System.Console.WriteLine(result.Message);
            }
        }
    }
}
