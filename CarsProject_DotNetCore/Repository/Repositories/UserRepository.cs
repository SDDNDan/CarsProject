using Domain;
using Repository.Interfaces;


namespace Repository.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AplicationContext context) : base(context) { }

        public AplicationContext AplicationContext
        {
            get { return Context as AplicationContext; }
        }
    }
}