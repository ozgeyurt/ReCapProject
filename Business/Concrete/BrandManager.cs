using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult("Brand Added");
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult("Brand Deleted");
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public IDataResult<List<Brand>> GetAllByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(b => b.BrandId == brandId), "Brands listed");
        }

        public Brand GetById(int brandId)
        {
            return _brandDal.Get(b => b.BrandId == brandId);
        }

        IDataResult<List<Brand>> IBrandService.GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }
    }
}
