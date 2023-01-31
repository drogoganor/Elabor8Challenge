using AutoMapper;
using Elabor8Challenge.CatFactsAPI.DTOs;
using Elabor8Challenge.CatFactsAPI.Model;

namespace Elabor8Challenge.CatFactsAPI.Mapping
{
    public class CatFactsProfile : Profile
    {
        public CatFactsProfile()
        {
            CreateMap<CatFact, CatFactSummaryDto>()
                .ForMember(dest => dest.Id, config => config.MapFrom(source => source.Id))
                .ForMember(dest => dest.Text, config => config.MapFrom(source => source.Text))
                .ForMember(dest => dest.Type, config => config.MapFrom(source => source.Type.ToString().ToLowerInvariant()))
                .ForMember(dest => dest.User, config => config.MapFrom(source => source.User))
                .ForMember(dest => dest.Upvotes, config => config.MapFrom(source => source.Upvotes))
                .ForMember(dest => dest.UserUpvoted, config => config.MapFrom(source => source.UserUpvoted));

            CreateMap<User, UserDto>()
                .ForMember(dest => dest.Id, config => config.MapFrom(source => source.Id))
                .ForMember(dest => dest.Name, config => config.MapFrom(source => source.Name));

            CreateMap<Name, NameDto>()
                .ForMember(dest => dest.First, config => config.MapFrom(source => source.First))
                .ForMember(dest => dest.Last, config => config.MapFrom(source => source.Last));

            CreateMap<CatFact, CatFactDetailDto>()
                .ForMember(dest => dest.Id, config => config.MapFrom(source => source.Id))
                .ForMember(dest => dest.Text, config => config.MapFrom(source => source.Text))
                .ForMember(dest => dest.Type, config => config.MapFrom(source => source.Type.ToString().ToLowerInvariant()))
                .ForMember(dest => dest.Source, config => config.MapFrom(source => source.Source.ToString().ToLowerInvariant()))
                .ForMember(dest => dest.Deleted, config => config.MapFrom(source => source.Deleted))
                .ForMember(dest => dest.CreatedAt, config => config.MapFrom(source => source.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, config => config.MapFrom(source => source.UpdatedAt))
                .ForMember(dest => dest.User, config => config.MapFrom(source => source.User.Id))
                .ForMember(dest => dest.V, config => config.MapFrom(source => source.V))
                .ForMember(dest => dest.Status, config => config.MapFrom(source => source.Status));

            CreateMap<FactStatus, FactStatusDto>()
                .ForMember(dest => dest.Verified, config => config.MapFrom(source => source.Verified))
                .ForMember(dest => dest.SentCount, config => config.MapFrom(source => source.SentCount));
        }
    }
}
