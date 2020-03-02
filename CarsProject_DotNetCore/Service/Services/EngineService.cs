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
   public class EngineService : IEngineService
    {
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EngineService( IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void DeleteEngine(Guid Id)
        {
            Engine engine = _unitOfWork.Engines.Get(Id);
            _unitOfWork.Engines.Remove(engine);
            _unitOfWork.Complete();
        }

        public EngineDTO GetEngine(Guid Id)
        {
            Engine engine =  _unitOfWork.Engines.Get(Id) as Engine;
            return _mapper.Map<EngineDTO>(engine);
        }

        public void InsertEngine(EngineDTO engineDTO)
        {
            Engine engine = _mapper.Map<Engine>(engineDTO);
            engine.EngineId = Guid.NewGuid();
            _unitOfWork.Engines.Add(engine);
            _unitOfWork.Complete();
        }

        public void UpdateEngine(EngineDTO engineDTO)
        {
            throw new NotImplementedException();
        }

    }
}
