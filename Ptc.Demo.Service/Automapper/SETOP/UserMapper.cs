using AutoMapper;
using Ptc.Demo.DataBase.SETOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Service.Automapper.SETOP
{
    public static class UserMapper
    {

        public class UserProfile : Profile
        {
            public UserProfile()
            {
                CreateMap<AspNetUsers, Domain.Business.Class.User>()
                     .ForMember(dest => dest.UserID, opt => opt.MapFrom(src => src.Id))
                     .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
                     .ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => src.PasswordHash))
                     .ReverseMap();

            }


        }
    }
}
