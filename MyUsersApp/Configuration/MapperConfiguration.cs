using AutoMapper;
using MyUsersApp.DTOs;
using MyUsersApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUsersApp.Configuration
{
    public class MapperConfiguration:Profile
    {
        public MapperConfiguration()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
        }
    }
}
