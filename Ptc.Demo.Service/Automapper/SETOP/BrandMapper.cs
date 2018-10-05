using AutoMapper;
using Ptc.Demo.Domain.Business.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Service.Automapper.SETOP
{
    public static class BrandMapper
    {
        public class BrandProfile : Profile
        {
            public BrandProfile()
            {

                CreateMap<DataBase.SETOP.Brand, Brand>()
                 .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID))
                 .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                 .ForMember(dest => dest.eShopName, opt => opt.MapFrom(src => src.eShopName))
                 .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
                 .ForMember(dest => dest.Tel, opt => opt.MapFrom(src => src.Tel))
                 .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Url))
                 .ForMember(dest => dest.eShopURL, opt => opt.MapFrom(src => src.eShopURL))
                 .ForMember(dest => dest.IsDisabled, opt => opt.MapFrom(src => src.IsDisabled))
                 .ForMember(dest => dest.IsHaveStore, opt => opt.MapFrom(src => src.IsHaveStore))
                 .ForMember(dest => dest.OPExchangeState, opt => opt.MapFrom(src => src.OPExchangeState))
                 .ForMember(dest => dest.Notice, opt => opt.MapFrom(src => src.Notice))
                 .ForMember(dest => dest.ActivityNotice, opt => opt.MapFrom(src => src.ActivityNotice))
                 .ForMember(dest => dest.Sort, opt => opt.MapFrom(src => src.Sort))
                 .ForMember(dest => dest.XLImageFileName, opt => opt.MapFrom(src => src.XLImageFileName))
                 .ForMember(dest => dest.SImageFileName, opt => opt.MapFrom(src => src.SImageFileName))
                 .ForMember(dest => dest.LastUpdateTime, opt => opt.MapFrom(src => src.LastUpdateTime))
                 .ForMember(dest => dest.LastUpdateUserName, opt => opt.MapFrom(src => src.LastUpdateUserName))
                 .ReverseMap();


            }

        }

    }
}
