﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car(){ Id=1,BrandId=1,ColorId=2,DailyPrice=300,Description="Vaz2107",ModelYear=new DateTime(2013,4,10)},
                new Car(){ Id=1,BrandId=1,ColorId=2,DailyPrice=300,Description="Vaz2107",ModelYear=new DateTime(2013,4,10)},
                new Car(){ Id=1,BrandId=1,ColorId=2,DailyPrice=300,Description="Vaz2107",ModelYear=new DateTime(2013,4,10)},
                new Car(){ Id=1,BrandId=1,ColorId=2,DailyPrice=300,Description="Vaz2107",ModelYear=new DateTime(2013,4,10)},
                new Car(){ Id=1,BrandId=1,ColorId=2,DailyPrice=300,Description="Vaz2107",ModelYear=new DateTime(2013,4,10)}

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

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _cars.Where(x => x.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.FirstOrDefault(x => x.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
