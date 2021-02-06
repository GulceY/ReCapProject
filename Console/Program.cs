using DataAccess.Concrete;
using Entities_.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car() { };
            Car car2 = new Car() { };
            InMemory memory = new InMemory();
            memory.Add(car1);
            memory.Delete(15);
            memory.GetAll();
            memory.UpDate(car2);
            memory.GetById(13);
        }
    }
}
