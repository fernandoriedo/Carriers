
using System.Collections.Generic;
using Carriers.Domain.Entities;
using Carriers.Domain.Interfaces.Services;

namespace Carriers.Application.Interfaces
{

    public class RatingAppService : AppServiceBase<Rating>, IRatingAppService
    {
        private readonly IRatingService _ratingService;

        public RatingAppService(IRatingService  ratingService)
            : base(ratingService)
        {
            _ratingService = ratingService;
        }

        public IEnumerable<Rating> FindByNote(int note)
        {
            return _ratingService.FindByNote(note);
        }
    }
}
