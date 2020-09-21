using API.Dtos;
using API.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Profiles
{
    public class UserProfiles : Profile
    {
        public UserProfiles()
        {
            //Source -> Target
            CreateMap<User, UserReadDto>();

            //Target -> Source
            CreateMap<UserCreateDto, User>();
        }
    }
}
