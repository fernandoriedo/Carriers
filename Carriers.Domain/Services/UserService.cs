
using Carriers.Domain.Entities;
using Carriers.Domain.Interfaces.Repositories;
using Carriers.Domain.Interfaces.Services;

namespace Carriers.Domain.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
            : base(userRepository)
        {
            _userRepository = userRepository;
        }
    }
}
