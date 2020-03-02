using Domain;
using System;


namespace Service.Interfaces
{
    public interface IChassisService
    {
        Chassis GetChassis(Guid Id);
        void InsertChassis(Chassis chassis);
        void UpdateChassis(Chassis chassis);
        void DeleteChassis(Guid Id);
    }
}
