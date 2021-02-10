using DataAccess.Abstract;
using Entities_.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryProductDal:IEntityRepository<Car>
    {
        List<Car> cars;
        public InMemoryProductDal()
        {
            cars = new List<Car> {
                new Car{BrandId=1, CarId=13, ColorId=2, DailyPrice=200, ModelYear=2008},
                new Car{BrandId=2, CarId=14, ColorId=2, DailyPrice=1000, ModelYear=2019},
                new Car{BrandId=2, CarId=15, ColorId=2, DailyPrice=1200, ModelYear=2020},
                new Car{BrandId=3, CarId=16, ColorId=2, DailyPrice=500, ModelYear=2018},
                new Car{BrandId=4, CarId=17, ColorId=2, DailyPrice=250, ModelYear=2014}

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
            
            
        }

        public List<Car> GetById(int Id)
        {
            return cars.Where(c => c.CarId == Id).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
