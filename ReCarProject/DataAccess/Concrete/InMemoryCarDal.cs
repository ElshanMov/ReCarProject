using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car(){ Id=1,BrandId=1,DailyPrice=300,Description="Vaz2107",ModelYear=new DateTime(2013,4,10)},
                new Car(){ Id=1,BrandId=1,DailyPrice=300,Description="Vaz2107",ModelYear=new DateTime(2013,4,10)},
                new Car(){ Id=1,BrandId=1,DailyPrice=300,Description="Vaz2107",ModelYear=new DateTime(2013,4,10)},
                new Car(){ Id=1,BrandId=1,DailyPrice=300,Description="Vaz2107",ModelYear=new DateTime(2013,4,10)},
                new Car(){ Id=1,BrandId=1,DailyPrice=300,Description="Vaz2107",ModelYear=new DateTime(2013,4,10)}

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.FirstOrDefault(x => x.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _cars.Where(x => x.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.FirstOrDefault(x => x.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
