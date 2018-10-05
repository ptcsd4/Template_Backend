using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Service.Automapper.SETOP
{
    public static class SETOPMapper
    {
        public static MapperConfiguration Config = new MapperConfiguration(config =>
        {      
            config.AddProfile<UserMapper.UserProfile>();
            config.AddProfile<BrandMapper.BrandProfile>();
        });

    }
}
