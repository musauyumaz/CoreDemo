using Application.Features.Comments.Commands.Create;
using Application.Features.Comments.Commands.Update;
using Application.Features.Comments.Queries.GetById;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Comments.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Comment, CreateCommentCommandRequest>().ReverseMap();
            CreateMap<Comment, UpdateCommentCommandRequest>().ReverseMap();
            CreateMap<Comment, GetByIdCommentQueryResponse>().ReverseMap();
        }
    }
}
