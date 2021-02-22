using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : EFEntityRepositoryBase<Car, DailyCarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (DailyCarRentalContext context= new DailyCarRentalContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join x in context.Colors
                             on c.ColorId equals x.ColorId
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = b.BrandName,
                                 ColorName = x.ColorName,
                                 DailyPrice = c.DailyPrice,



                             };
                return result.ToList();
            }
        }
    }
}