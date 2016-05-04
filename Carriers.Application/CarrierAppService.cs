
using System.Collections.Generic;
using Carriers.Application.Interfaces;
using Carriers.Domain.Entities;
using Carriers.Domain.Interfaces.Services;

namespace Carriers.Application
{
    public class CarrierAppService : AppServiceBase<Carrier>, ICarrierAppService
    {
        private readonly ICarrierService _carrierService;

        public CarrierAppService(ICarrierService carrierService)
            : base(carrierService)
        {
            _carrierService = carrierService;
        }
        
    }
}