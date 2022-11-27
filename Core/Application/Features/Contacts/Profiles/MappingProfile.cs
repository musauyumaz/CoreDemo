using Application.Features.Contacts.Commands.Create;
using Application.Features.Contacts.Commands.Update;
using Application.Features.Contacts.Queries.GetById;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Contacts.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Contact, CreateContactCommandRequest>().ReverseMap();
            CreateMap<Contact, UpdateContactCommandRequest>().ReverseMap();
            CreateMap<Contact, GetByIdContactQueryResponse>().ReverseMap();
        }
    }
}
