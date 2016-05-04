using System.Collections.Generic;
using Carriers.Domain.Entities;

namespace Carriers.Domain.Interfaces.Repositories
{
    public interface IRatingRepository : IRepositoryBase<Rating>
    {
        IEnumerable<Rating> FindByNote(int note);
    }
}
