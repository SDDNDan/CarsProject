using Domain;
using Repository.Interfaces;


namespace Repository.Repositories
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(AplicationContext context) : base(context) { } 

        public AplicationContext AplicationContext
        {
            get { return Context as AplicationContext; }
        }
    }
}