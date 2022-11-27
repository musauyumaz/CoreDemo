using Application.Features.Writers.Commands.Create;
using Application.Features.Writers.Commands.Update;
using Application.Features.Writers.Queries.GetById;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Writers.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Writer, CreateWriterCommandRequest>().ReverseMap();
            CreateMap<Writer, UpdateWriterCommandRequest>().ReverseMap();
            CreateMap<Writer, GetByIdWriterQueryResponse>().ReverseMap();
        }
    }
}
