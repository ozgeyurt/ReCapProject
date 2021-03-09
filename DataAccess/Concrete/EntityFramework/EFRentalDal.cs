using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFRentalDal : EFEntityRepositoryBase<Rental, DailyCarRentalContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            throw new System.NotImplementedException();
        }
    }
}
