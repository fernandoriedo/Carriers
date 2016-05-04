
using System.Collections.Generic;
using Carriers.Domain.Entities;

namespace Carriers.Application.Interfaces
{
    public interface IRatingAppService : IAppServiceBase<Rating>
    {
        IEnumerable<Rating> FindByNote(int note);
    }
}
