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
        private AplicationContext _aplicationContext;
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EngineService(AplicationContext aplicationContext, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _aplicationContext = aplicationContext;
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
            //throw new NotImplementedException();
        }

        public void InsertEngine(EngineDTO engine)
        {
            throw new NotImplementedException();
        }

        public void UpdateEngine(EngineDTO engine)
        {
            throw new NotImplementedException();
        }

    }
}
