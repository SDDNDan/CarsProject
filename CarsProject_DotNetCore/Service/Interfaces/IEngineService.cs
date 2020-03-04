// Order should be
// System
// Service

using Domain; // Why domain here?
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
