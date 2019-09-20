using aspnetcore_template.ServiceModel.Entities;
using aspnetcore_template.ViewModels;
using AutoMapper;

namespace aspnetcore_template.MVC.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Restaurant, HomePageViewModel>()
                          .ForMember(dest => dest.Actions, opt => opt.MapFrom(src => RestaurantTransforms.ProcessServerActionsAnchor(src.Id)));
        }
    }
}
