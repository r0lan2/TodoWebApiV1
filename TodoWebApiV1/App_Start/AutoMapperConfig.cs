using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoWebApiV1.App_Start
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Entities.Todo, Models.TodoDTO>();
                cfg.CreateMap<Models.TodoDTO, Entities.Todo>();

            });
        }
    }
}