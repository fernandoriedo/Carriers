
using AutoMapper;
using Carriers.Domain.Entities;
using Carriers.MVC.ViewModels;

namespace Carriers.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            CreateMap<Carrier, CarrierViewModel>();
            CreateMap<Rating, RatingViewModel>();
            CreateMap<User, UserViewModel>();

            //var config = new MapperConfiguration(cfg => {
            //    cfg.CreateMap<CarrierViewModel, Carrier>();
            //    cfg.CreateMap<RatingViewModel, Rating>();
            //});

            //IMapper mapper = config.CreateMapper();
            //var source = new RatingViewModel();
            //var dest = mapper.Map<RatingViewModel, Rating>(source);
        }
    }
}
