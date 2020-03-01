using Domain;
using Repository.Interfaces;


namespace Repository.Repositories
{
    public class EngineRepository : Repository<Engine>, IEngineRepository
    {
        public EngineRepository(AplicationContext context) : base(context) { }

        public AplicationContext AplicationContext
        {
            get { return Context as AplicationContext; }
        }
    }
}