using Domain;
using Service.DTO;
using System;


namespace Service.Interfaces
{
    public interface IEngineService
    {
        EngineDTO GetEngine(Guid Id);
        void InsertEngine(EngineDTO engine);
        void UpdateEngine(EngineDTO engine);
        void DeleteEngine(Guid Id);
    }
}
