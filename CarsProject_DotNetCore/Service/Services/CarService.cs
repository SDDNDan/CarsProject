using System;
using System.Collections.Generic;
using Domain;
using Repository;
using Repository.Interfaces;
using Repository.UnitOfWork;
using Service.Interfaces;

namespace Service.Services
{
    public class CarService : ICarService
    {
        private AplicationContext _aplicationContext;
        private IUnitOfWork _unitOfWork;

        public CarService(AplicationContext aplicationContext, IUnitOfWork unitOfWork)
        {
            _aplicationContext = aplicationContext;
            _unitOfWork = unitOfWork;
        }

        public void DeleteCar(Guid Id)
        {
            Car car = _unitOfWork.Cars.Get(Id);
            _unitOfWork.Cars.Remove(car);
        }

        public Car GetCar(Guid Id)                  
        {
            Car car = _unitOfWork.Cars.Get(Id) as Car;

           // return //DTOCAr
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetCars()
        {
            return _unitOfWork.Cars.GetAll() as IEnumerable<Car>;
        }

        public void InsertCar(Car car)
        {
            _unitOfWork.Cars.Add(car);
        }

        public void UpdateCar(Car updatedCar)                                 
        {
            Car originalCar = _unitOfWork.Cars.Get(updatedCar.CarId);
            originalCar.ChassisId = updatedCar.ChassisId;
            originalCar.Brand = updatedCar.Brand;
            originalCar.EngineId = updatedCar.EngineId;
            originalCar.CarUsers = updatedCar.CarUsers;
        }
    }
}