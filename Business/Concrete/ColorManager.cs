using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {

            _colorDal.Add(color);
            return new SuccessResult("color added");
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult("color Deleted");
        }

       

        public IDataResult<List<Color>> GetAllByColorId(int colorId)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(x => x.ColorId == colorId), "Colors listed"); 
        }

       
        IDataResult<List<Color>> IColorService.GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }
    }
}
