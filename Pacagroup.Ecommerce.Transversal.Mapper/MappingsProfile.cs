using AutoMapper;
using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Domain.Entity;

namespace Pacagroup.Ecommerce.Transversal.Mapper
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Customers, CustomersDTO>().ReverseMap();

            //CreateMap<Customers, CustomersDTO>().ReverseMap()
            //    .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId));
        }
    }
}

