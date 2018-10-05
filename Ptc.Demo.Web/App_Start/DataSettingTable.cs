using Ptc.Data.Condition2.Interface.Common;
using Ptc.Data.Condition2.Mssql.Common;
using Ptc.Demo.DataBase.SETOP;
using Ptc.Demo.Service.Automapper;
using Ptc.Demo.Service.Automapper.SETOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ptc.Demo.Web
{
    public static class DataSettingTable
    {

        public static ISetup[] Setups = new ISetup[]
        {
            new MSSQLDataSetting()
            {
                DefaultDBContextDelegate = () =>
                {
                    return new SETOPEntities();
                },
                DefaultMappingConfig = () =>
                {
                    MapperContainer.SetConfig(SETOPMapper.Config);
                    return MapperContainer.Mapper;
                }
            }
        };


    }
}