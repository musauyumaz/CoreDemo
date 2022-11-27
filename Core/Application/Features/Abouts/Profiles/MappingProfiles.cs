using Application.Features.Abouts.Commands.Create;
using Application.Features.Abouts.Commands.Update;
using Application.Features.Abouts.DTOs;
using Application.Features.Abouts.Models;
using Application.Features.Abouts.Queries.GetById;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Abouts.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            //CreateMap<, >().ReverseMap();
            CreateMap<About, AboutListDto>().ReverseMap();
            CreateMap<List<About>, AboutListModel>().ReverseMap();
            CreateMap<About, GetByIdAboutQueryResponse>().ReverseMap();
            CreateMap<About, CreateAboutCommandRequest>().ReverseMap();
            CreateMap<About, UpdateAboutCommandRequest>().ReverseMap();
            
        }
    }
}
