using AutoMapper;
using Ptc.Demo.DataBase.SETOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Service.Automapper.SETOP
{
    public static class TradeMapper
    {


        public class TradeProfile : Profile
        {

            public TradeProfile()
            {
                CreateMap<Trade, Domain.Business.Class.Trade>()
                     .ForMember(dest => dest.GUID, opt => opt.MapFrom(src => src.GUID))
                     .ForMember(dest => dest.SerialNumber, opt => opt.MapFrom(src => src.SerialNumber))
                     .ForMember(dest => dest.TransactionID, opt => opt.MapFrom(src => src.TransactionID))
                     .ReverseMap();
            }
        }


    }
}
