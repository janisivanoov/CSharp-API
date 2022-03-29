using AutoMapper;
using mysqltest.Mapping.DTO.Covid;
using mysqltest.Models.CovidCases;

namespace mysqltest.Mapping
{
    public class CovidProfile : Profile
    {
        public CovidProfile()
        {
            CreateMap<Covid, CovidDTO>();
        }
    }
}