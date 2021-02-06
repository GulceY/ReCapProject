using DataAccess.Abstract;
using Entities_.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemory:ICar
    {
        List<Car> cars;
        public InMemory()
        {
            cars = new List<Car> {
                new Car{BrandId=1, CarId=13, ColorId=2, DailyPrice=200, ModelYear=2008, Description="Benzin,Manuel"},
                new Car{BrandId=2, CarId=14, ColorId=2, DailyPrice=1000, ModelYear=2019, Description="Dizel,Otomatik"},
                new Car{BrandId=2, CarId=15, ColorId=2, DailyPrice=1200, ModelYear=2020, Description="Dizel,Otomatik"},
                new Car{BrandId=4, CarId=16, ColorId=2, DailyPrice=500, ModelYear=2018, Description="Dizel,Manuel"},
                new Car{BrandId=3, CarId=17, ColorId=2, DailyPrice=250, ModelYear=2014, Description="Benzin,Manuel"}

            };
        }

        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(int carId)
        {
            Car delete = cars.SingleOrDefault(c => c.CarId == carId);
            cars.Remove(delete);
        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public void UpDate(Car car)
        {
            Car update = cars.SingleOrDefault(c => c.CarId == car.CarId);
            update.BrandId = car.BrandId;
            update.ColorId = car.ColorId;
            update.DailyPrice = car.DailyPrice;
            update.ModelYear = car.ModelYear;
            update.Description = car.Description;
            
        }

        public List<Car> GetById(int Id)
        {
            return cars.Where(c => c.CarId == Id).ToList();
        }
    
    }
}
