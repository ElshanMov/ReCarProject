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

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult();
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult();
        }

        IResult IBrandService.Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult();
        }

        IDataResult<List<Brand>> IBrandService.GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }
    }
}
