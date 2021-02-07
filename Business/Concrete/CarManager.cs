using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);

        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(p=>p.BrandId==brandId);

        }

       

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(p => p.ColorId == colorId);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public void Add(Car car)
        {
           
            if (car.CarName.Length >= 2)
            {
                if (car.DailyPrice>0)
                {
                    _carDal.Add(car);
                    Console.WriteLine("Car Added Successfully");
                }
                else
                {
                    Console.WriteLine("Error! Daily price must be higher than 0");
                    Console.WriteLine("Please write a correct value for daily price");
                    car.DailyPrice = Convert.ToDecimal(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Error! The character of car name must not be shorter than 2");
                Console.WriteLine("Please write the characters of car name more than 2");
                car.CarName = Convert.ToString(Console.ReadLine());
            }
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Cars Updated Successfully");
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Car Deleted Successfully");
        }

        public List<Car> GetByCarModelYear(int min, int max)
        {
            return _carDal.GetAll(p => p.CarModelYear >= min && p.CarModelYear <= max);
        }
    }
}
