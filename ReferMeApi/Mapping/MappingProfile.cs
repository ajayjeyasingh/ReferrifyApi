using AutoMapper;
using ReferMeApi.Controllers.Resources;
using ReferMeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReferMeApi.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain to API Resource

            CreateMap<Company, CompanyResource>();
        }
    }
}
