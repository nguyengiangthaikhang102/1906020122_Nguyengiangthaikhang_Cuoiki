
using AutoMapper;
using TetrisApi.Dtos;
using TetrisApi.Models;

namespace TetrisAPI.Profiles
{
    public class TetrisProfile : Profile
    {
        public TetrisProfile()
        {
            // Source -> Target
            CreateMap<TetrisDtos,TetrisItem>()
                .ForMember(dest=>dest.UserName,act=>act.MapFrom(src=>src.UserName))
                .ForMember(dest=>dest.Score,act=>act.MapFrom(src=>src.Score));

            CreateMap<TetrisItem,TetrisItemCreatedDto>();
        }
    }
}