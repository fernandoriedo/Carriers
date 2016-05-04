using System.Collections.Generic;
using Carriers.Domain.Entities;

namespace Carriers.Domain.Interfaces.Services
{
    public interface IRatingService : IServiceBase<Rating>
    {
        IEnumerable<Rating> FindByNote(int note);
    }
}
