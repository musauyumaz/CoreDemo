using Application.Features.Blogs.Commands.Create;
using Application.Features.Blogs.Commands.Update;
using Application.Features.Blogs.Queries.GetById;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Blogs.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Blog,CreateBlogCommandRequest>().ReverseMap();
            CreateMap<Blog,UpdateBlogCommandRequest>().ReverseMap();
            CreateMap<Blog,GetByIdBlogQueryResponse>().ReverseMap();
        }
    }
}
