
using System.Collections.Generic;
using System.Linq;
using Carriers.Domain.Entities;
using Carriers.Domain.Interfaces;
using Carriers.Domain.Interfaces.Repositories;

namespace Carriers.Infra.Data.Repositories
{
    public class RatingRepository : RepositoryBase<Rating>, IRatingRepository
    {
        public IEnumerable<Rating> FindByNote(int note)
        {
            return Db.Ratings.Where(p => p.Note == note);
        }

    }
}
