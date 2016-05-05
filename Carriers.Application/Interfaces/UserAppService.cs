
using Carriers.Domain.Entities;
using Carriers.Domain.Interfaces.Services;

namespace Carriers.Application.Interfaces
{
    public class UserAppService : AppServiceBase<User>, IUserAppService
    {
        private readonly IUserService _userService;

        public UserAppService(IUserService userService)
            : base(userService)
        {
            _userService = userService;
        }

    }
}
