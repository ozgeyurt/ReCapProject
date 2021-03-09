using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EFCarDal());
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.ModelYear);
            //}


            //CarManager carManager = new CarManager(new EFCarDal());
            //foreach (var car in carManager.GetCarsByBrandId(3))
            //{
            //    Console.WriteLine(car.DailyPrice);
            //}

            //CarManager carManager = new CarManager(new EFCarDal());
            //foreach (var car in carManager.GetCarsByColorId(5))
            //{
            //    Console.WriteLine(car.DailyPrice);
            //}


            //    CarManager carManager = new CarManager(new EFCarDal());
            //    carManager.Add(new Entities.Concrete.Car { Id = 11, BrandId = 1, ColorId = 3, ModelYear = 2020, DailyPrice = 1000, Description = "Mercedes A200 otomatik" });
            //


            //BrandManager brandManager = new BrandManager(new EFBrandDal());
            // foreach (var brand in brandManager.GetAll())
            // {
            //     Console.WriteLine(brand.BrandName);
            // }

            // ColorManager colorManager = new ColorManager(new EFColorDal());
            // foreach (var color in colorManager.GetAll())
            // {
            //     Console.WriteLine(color.ColorName);
            // }

            CarManager carManager = new CarManager(new EFCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "/" + car.DailyPrice);
                }

                Console.WriteLine(result.Message);
            }

            CustomerManager customerManager = new CustomerManager(new EFCustomerDal());
            foreach (var customer in customerManager.GetAll())
            {
                Console.WriteLine(customer.CompanyName);
            }








        }


    }


}
