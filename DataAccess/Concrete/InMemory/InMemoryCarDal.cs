﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=2,ModelYear=2020,DailyPrice=350,Description="Audi A7"},
                new Car{Id=2,BrandId=2,ColorId=1,ModelYear=2020,DailyPrice=200,Description="Ford Fiesta"},
                new Car{Id=3,BrandId=3,ColorId=2,ModelYear=2019,DailyPrice=300,Description="Wolkswogen Golf"},
                new Car{Id=4,BrandId=4,ColorId=3,ModelYear=2018,DailyPrice=250,Description="Renault Clio"}
            };
        }
        public List<Car> GetAll()
        {
            return _cars;
        }
        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }
        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
