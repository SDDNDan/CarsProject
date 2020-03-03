using System;
using System.Collections.Generic;
using System.Linq;
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
            IEnumerable<Car> cars = _unitOfWork.Cars.GetAll();
            //IEnumerable<CarDTO> carsDTO = new CarDTO[] { };
            IEnumerable<CarDTO> carsDTO = _mapper.Map<IEnumerable<CarDTO>>(cars);
            return carsDTO;
            //foreach (var car in cars)
            //{
            //    CarDTO carDTO = new CarDTO();
            //    carDTO = _mapper.Map<CarDTO>(car);
            //    carDTO.Chassis = _mapper.Map<ChassisDTO>(car.Chassis);
            //    carDTO.Engine = _mapper.Map<EngineDTO>(car.Engine);
            //    carsDTO.ToList().Add(carDTO);
            //}
            //return carsDTO.ToList();
        }

        public CarDTO GetCar(Guid Id)
        {
            Car car = _unitOfWork.Cars.Get(Id) as Car;
            CarDTO carDTO =  _mapper.Map<CarDTO>(car);
            carDTO.Chassis = _mapper.Map<ChassisDTO>(car.Chassis);
            carDTO.Engine = _mapper.Map<EngineDTO>(car.Engine);
            return carDTO;
        }

        public Car GetCar22(Guid Id)
        {
            return _unitOfWork.Cars.Get(Id) as Car;
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