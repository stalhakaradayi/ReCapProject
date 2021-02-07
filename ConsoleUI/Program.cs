using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());




            Car car1 = new Car();
            Console.WriteLine("Car Name:");
            car1.CarName = Console.ReadLine();
            carManager.Add(car1);





            //Console.WriteLine("Car Id:" + car.CarId + "Car Name:" + car.CarName + "Car Model Year:" + car.CarModelYear + "Car Brand Id: " + car.BrandId + "Car Color Id:" + car.ColorId + "Car Daily Price" + car.DailyPrice + "Car Description:" + car.Description);


            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }


            



            Console.ReadLine();
        }
    }
}
