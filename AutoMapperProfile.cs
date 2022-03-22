using AutoMapper;
using HexagonSanDiego.Dtos.AmenityDtos;
using HexagonSanDiego.Dtos.ContactUsDto;
using HexagonSanDiego.Dtos.FloorPlanDtos;
using HexagonSanDiego.Dtos.PolicyDto;
using HexagonSanDiego.Dtos.TermsDto;
using HexagonSanDiego.Models;

namespace HexagonSanDiego
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<FloorPlan, GetFloorPlanDto>();
            CreateMap<AddAmenityDto, Amenity>();
            CreateMap<AddFloorPlanDto, FloorPlan>();
            CreateMap<UpdateFloorPlanDto, FloorPlan>();
            CreateMap<ContactUsDto, ContactUs>();
            CreateMap<PolicyDto, Policy>();
            CreateMap<TermsDto, Term>();
        }
    }
            
}
