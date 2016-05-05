
using Carriers.Domain.Entities;
using Carriers.Domain.Interfaces.Repositories;

namespace Carriers.Infra.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
    }
}
