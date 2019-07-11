using System;
using AutoMapper;

/// <summary>
/// https://www.codeproject.com/Articles/1256100/Automapper-Using-NET-Core-API-2-1
/// </summary>
namespace AutoMapperExample.Models
{
    public class UserProfileMap : Profile
    {
        public UserProfileMap()
        {
            CreateMap<User, UserViewModel>();
        }
    }
}
