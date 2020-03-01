using Domain;
using Repository.Interfaces;


namespace Repository.Repositories
{
    public class ChassisRepository : Repository<Chassis>, IChassisRepository
    {
        public ChassisRepository(AplicationContext context) : base(context) { }

        public AplicationContext AplicationContext
        {
            get { return Context as AplicationContext; }
        }
    }
}