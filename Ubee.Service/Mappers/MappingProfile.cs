﻿using AutoMapper;
using Ubee.Domain.Entities;
using Ubee.Service.DTOs;

namespace Ubee.Service.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<UserForCreationDto, User>().ReverseMap();
    }
}
