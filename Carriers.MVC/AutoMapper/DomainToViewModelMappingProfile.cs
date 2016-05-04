using AutoMapper;
using Carriers.Domain.Entities;
using Carriers.MVC.ViewModels;

namespace Carriers.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            CreateMap<CarrierViewModel, Carrier>();
            CreateMap<RatingViewModel, Rating>();
        }
    }
}
