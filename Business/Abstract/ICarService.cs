using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int brandid);
        List<Car> GetCarsByColorId(int colorid);
        bool Add(Car car);
        List<CarDetailDto> GetCarDetails();

    }
}
