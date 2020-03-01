using System;


namespace Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICarRepository Cars { get; }
        IChassisRepository Chassiss { get; }
        IEngineRepository Engines { get; }
        IUserRepository Users { get; }
        int Complete();
    }
}
