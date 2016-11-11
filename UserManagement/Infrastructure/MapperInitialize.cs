using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserManagement.Models;
using AutoMapper;
using UserManagement.ServiceReference;

namespace UserManagement.Infrastructure
{
    public class MapperInitialize
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<User, UserViewModel>()
                        .ForMember(u => u.listItems, opt => opt.Ignore())
                        .ReverseMap();
                });
            Mapper.AssertConfigurationIsValid();
        }
    }
}