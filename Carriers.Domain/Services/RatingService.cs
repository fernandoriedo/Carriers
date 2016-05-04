
using System.Collections.Generic;
using Carriers.Domain.Entities;
using Carriers.Domain.Interfaces.Repositories;
using Carriers.Domain.Interfaces.Services;

namespace Carriers.Domain.Services
{
    public class RatingService : ServiceBase<Rating>, IRatingService
    {
        private readonly IRatingRepository _ratingRepository;

        public RatingService(IRatingRepository ratingRepository)
            : base(ratingRepository)
        {
            _ratingRepository = ratingRepository;
        }

        public IEnumerable<Rating> FindByNote(int note)
        {
            return _ratingRepository.FindByNote(note);
        }
    }
}
