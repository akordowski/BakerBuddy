using AutoMapper;
using BakerBuddy.Data.Entities;
using BakerBuddy.Domain.Dto;

namespace BakerBuddy.Application.Mappings.Profiles;

public class UserEntityProfile : Profile
{
    public UserEntityProfile()
    {
        CreateMap<UserDataDto, UserEntity>();
    }
}