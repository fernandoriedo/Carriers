
using System.Collections.Generic;
using System.Linq;
using Carriers.Domain.Entities;
using Carriers.Domain.Interfaces.Repositories;
using Carriers.Domain.Interfaces.Services;

namespace Carriers.Domain.Services
{
    public class CarrierService : ServiceBase<Carrier>, ICarrierService
    {
        private readonly ICarrierRepository _carrierRepository;

        public CarrierService(ICarrierRepository carrierRepository)
            : base(carrierRepository)
        {
            _carrierRepository = carrierRepository;
        }
    }
}
