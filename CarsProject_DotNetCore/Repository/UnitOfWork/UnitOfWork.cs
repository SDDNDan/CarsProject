using Repository.Repositories;
using Repository.Interfaces;


namespace Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AplicationContext _context;

        public UnitOfWork(AplicationContext context)
        {
            _context = context;
            Cars = new CarRepository(_context);
            Chassiss = new ChassisRepository(_context);
            Engines = new EngineRepository(_context);
            Users = new UserRepository(_context);
        }
        public ICarRepository Cars { get; private set; }
        public IChassisRepository Chassiss { get; private set; }
        public IEngineRepository Engines { get; private set; }
        public IUserRepository Users { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}