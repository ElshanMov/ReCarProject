using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return new List<Car>()
            {
                new Car
                {
                    Id = 1,
                    BrandId = 2, 
                    ColorId = 1,
                    DailyPrice = 250,
                    Description = "TOGG",
                    ModelYear = new DateTime(2022, 05, 01)
                }
            };
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
