using AutoMapper;
using Domain;
using Repository;
using Repository.Interfaces;
using Service.DTO;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class ChassisService : IChassisService
    {
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ChassisService( IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void DeleteChassis(Guid Id)
        {
            Chassis chassis = _unitOfWork.Chassiss.Get(Id);
            _unitOfWork.Chassiss.Remove(chassis);
            _unitOfWork.Complete();
        }

        public ChassisDTO GetChassis(Guid Id)
        {
            Chassis chassis = _unitOfWork.Chassiss.Get(Id) as Chassis;
            return _mapper.Map<ChassisDTO>(chassis);
        }

        public void InsertChassis(ChassisDTO chassisDTO)
        {
            Chassis chassis = _mapper.Map<Chassis>(chassisDTO);
            chassis.ChassisId = Guid.NewGuid();
            _unitOfWork.Chassiss.Add(chassis);
            _unitOfWork.Complete();
        }

        public void UpdateChassis(ChassisDTO chassisDTO)
        {
            throw new NotImplementedException();
        }
    }
}
