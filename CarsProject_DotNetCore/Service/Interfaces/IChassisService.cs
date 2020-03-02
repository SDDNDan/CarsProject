using Domain;
using Service.DTO;
using System;


namespace Service.Interfaces
{
    public interface IChassisService
    {
        ChassisDTO GetChassis(Guid Id);
        void InsertChassis(ChassisDTO chassisDTO);
        void UpdateChassis(ChassisDTO chassisDTO);
        void DeleteChassis(Guid Id);
    }
}
