// The order should be 
// System
// Service

using Domain; //Why domain here?
using Service.DTO;
using System;
using System.Collections.Generic;

namespace Service.Interfaces
{
    public interface ICarService
    {
        IEnumerable<CarDTO> GetCars();
        CarDTO GetCar(Guid Id);
        void InsertCar(CarDTO carDTO);
        void UpdateCar(CarDTO carDTO);
        void DeleteCar(Guid Id);

        Car GetCar22(Guid Id);
    }
}
