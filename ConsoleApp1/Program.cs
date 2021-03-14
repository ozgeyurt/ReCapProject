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
            //var result = carManager.GetCarDetails();
            //if (result.Success == true)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.BrandName + "/" + car.DailyPrice);
            //    }

            //    Console.WriteLine(result.Message);
            //}

            //private static void BrandColor()
            //{
            //    BrandManager brandManager = new BrandManager(new EFBrandDal());
            //    foreach (var brand in brandManager.GetAll())
            //    {
            //        Console.WriteLine(brand.BrandName);
            //    }

            //    ColorManager colorManager = new ColorManager(new EFColorDal());
            //    foreach (var color in colorManager.GetAll())
            //    {
            //        Console.WriteLine(color.ColorName);
            //    }
            //}


            //CarManager carManager = new CarManager(new EFCarDal());
            //carManager.Add(new Entities.Concrete.Car { Id = 11, BrandId = 1, ColorId = 3, ModelYear = 2020, DailyPrice = 1000, Description = "Mercedes A200 otomatik" });


            //private static void Get()
            //{
            //    CarManager carManager = new CarManager(new EFCarDal());
            //    foreach (var car in carManager.GetAll())
            //    {
            //        Console.WriteLine(car.ModelYear);
            //    }


            //    CarManager carManager = new CarManager(new EFCarDal());
            //    foreach (var car in carManager.GetCarsByBrandId(3))
            //    {
            //        Console.WriteLine(car.DailyPrice);
            //    }

            //    CarManager carManager = new CarManager(new EFCarDal());
            //    foreach (var car in carManager.GetCarsByColorId(5))
            //    {
            //        Console.WriteLine(car.DailyPrice);
            //    }
            //}


            //UserManager userManager = new UserManager(new EFUserDal());
            //foreach (var user in userManager.GetAll().Data)
            //{
            //    Console.WriteLine(user.FirstName + user.LastName + user.Email);
            //}
            //CustomerManager customerManager = new CustomerManager(new EFCustomerDal());
            //foreach (var customer in customerManager.GetAll().Data)
            //{
            //    Console.WriteLine(customer.CompanyName);
            //}



            RentalManager rentalManager = new RentalManager(new EFRentalDal());
            foreach (var rental in rentalManager.GetRentalDetails().Data)
            {
                Console.WriteLine(rental.FullName + ' ' + rental.CompanyName + ' ' + rental.Description + ' ' + rental.Description + ' ' + rental.RentDate + ' ' + rental.ReturnDate);
            }

        }


    }
    }
