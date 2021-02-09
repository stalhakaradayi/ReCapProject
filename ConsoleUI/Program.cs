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

            //CarManager carManager = new CarManager(new EfCarDal());
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //ColorManager colorManager = new ColorManager(new EfColorDal());


            //-----------------------------------New Color-------------------------------------------------          
            //colorManager.Add(new Color
            //{
            //  ColorId =12,
            //  ColorName ="Orange"
            //}); //To add new color.

            //-----------------------------------New Brand-------------------------------------------------  

            //brandManager.Add(new Brand
            //{
            //    BrandId = 60,
            //    BrandName = "G"
            //});  //To add new brand.

            //-----------------------------------New Car-------------------------------------------------  

            //carManager.Add(new Car
            //{
            //    CarId = 38,
            //    CarName = "TOGG",
            //    BrandId = 58,
            //    ColorId = 2,
            //    CarModelYear = 2020,
            //    DailyPrice = 400,
            //    Description = "Automatic"
            //}); //To add new car.

           
            //-----------------------------------All Car List-------------------------------------------------
           
            //AllCarList(carManager);  // Thanks to this method, all car will be listed on console.


            Console.ReadLine();

        }

        private static void AllCarList(CarManager carManager)
        {
           
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------------------------Car List--------------------------------------");

            Console.WriteLine(" ");


            Console.WriteLine(String.Format("{0,-12}  |  {1,-12}  |  {2,-12}  | {3,-12}  |  {4,-12}", "Car Id", "Brand Name", "CarName", "Daily Price", "Description"));
            Console.WriteLine(String.Format("----------------------------------------------------------------------------------"));
            Console.ResetColor();

            Console.WriteLine("");




            Console.ForegroundColor = ConsoleColor.White;
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(String.Format("{0,-12}  |  {1,-12}  |  {2,-12}  |  {3,-12}  |  {4,-12}", car.CarId, car.BrandName, car.CarName, car.DailyPrice, car.Description));
            }
        }
    }
}
