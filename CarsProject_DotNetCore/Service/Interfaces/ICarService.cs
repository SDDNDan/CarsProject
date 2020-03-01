using Domain;
using System;
using System.Collections.Generic;

namespace Service.Interfaces
{
    public interface ICarService
    {
        IEnumerable<Car> GetCars();
        Car GetCar(Guid Id);
        void InsertCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(Guid Id);
    }
}
