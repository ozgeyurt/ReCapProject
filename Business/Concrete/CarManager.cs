using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public bool Add(Car car)
        {
            if (car.DailyPrice>0 && car.Description.Length>=2)
            {
                _carDal.Add(car);
                return true;
            }
            else
            {
                Console.WriteLine("Hatalı isim ya da tutar girdiniz");
                return false;
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int brandid)
        {
            return _carDal.GetAll(c => c.BrandId == brandid);
        }

        public List<Car> GetCarsByColorId(int colorid)
        {
            return _carDal.GetAll(c => c.ColorId == colorid);
        }

      
    }
}
