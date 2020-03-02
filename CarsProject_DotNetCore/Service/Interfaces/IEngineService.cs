using Domain;
using Service.DTO;
using System;


namespace Service.Interfaces
{
    public interface IEngineService
    {
        EngineDTO GetEngine(Guid Id);
        void InsertEngine(EngineDTO engineDTO);
        void UpdateEngine(EngineDTO engineDTO);
        void DeleteEngine(Guid Id);
    }
}
