using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Service.Automapper
{
    public static class MapperContainer
    {
        public static IMapper Mapper = null;

        public static TDestination Map<TDestination>(object data)
        {
            try
            {
                if (Mapper == null)
                    throw new NullReferenceException("[Automapper] Instance is null");

                return Mapper.Map<TDestination>(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void SetConfig(MapperConfiguration config)
        {
            Mapper = config.CreateMapper();
        }
    }
}
