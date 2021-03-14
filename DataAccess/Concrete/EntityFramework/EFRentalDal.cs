using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFRentalDal : EFEntityRepositoryBase<Rental, DailyCarRentalContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (DailyCarRentalContext context=new DailyCarRentalContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id

                             join cs in context.Customers
                             on r.CustomerId equals cs.CustomerId

                             join u in context.Users
                             on cs.UserId equals u.UserId

                             select new RentalDetailDto
                             {
                                 RentalId = r.RentalId,
                                 CarId = c.Id,
                                 Description = c.Description,
                                 DailyPrice = c.DailyPrice,
                                 FullName= u.FirstName+' '+u.LastName,
                                 CompanyName = cs.CompanyName,
                                 RentDate=r.RentDate,
                                 ReturnDate=r.ReturnDate
                                 
                             };
                return result.ToList();
                             

            }
        }
    }
}
