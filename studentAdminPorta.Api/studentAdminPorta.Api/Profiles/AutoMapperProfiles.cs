using AutoMapper;
using studentAdminPorta.Api.DataModels;
using studentAdminPorta.Api.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studentAdminPorta.Api.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Student, StudentDTO>()
                .ReverseMap();
            CreateMap<Gender, GenderDTO>()
                .ReverseMap();
            CreateMap<Address, AddressDTO>()
                .ReverseMap();
        }
    }
}
