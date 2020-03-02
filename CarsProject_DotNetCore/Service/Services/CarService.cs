using System;
using System.Collections.Generic;
using AutoMapper;
using Domain;
using Repository;
using Repository.Interfaces;
using Repository.UnitOfWork;
using Service.DTO;
using Service.Interfaces;

namespace Service.Services
{
    public class CarService : ICarService
    {
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CarService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<CarDTO> GetCars()
        {
            IEnumerable<Car> Cars = _unitOfWork.Cars.GetAll();
            return _mapper.Map<IEnumerable<CarDTO>>(Cars);
        }

        public CarDTO GetCar(Guid Id)
        {
            Car car = _unitOfWork.Cars.Get(Id) as Car;
            return _mapper.Map<CarDTO>(car);
        }

        public void InsertCar(CarDTO carDTO)
        {
            Car car = _mapper.Map<Car>(carDTO);
            car.CarId = Guid.NewGuid();
            _unitOfWork.Cars.Add(car);
            _unitOfWork.Complete();
        }

        public void UpdateCar(CarDTO carDTO)
        {
            throw new NotImplementedException();
        }

        public void DeleteCar(Guid Id)
        {
            Car car = _unitOfWork.Cars.Get(Id);
            _unitOfWork.Cars.Remove(car);
            _unitOfWork.Complete();
        }

    }
}