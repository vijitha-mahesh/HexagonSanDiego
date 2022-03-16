using AutoMapper;
using HexagonSanDiego.Dtos.FloorPlanDtos;
using HexagonSanDiego.Models;

namespace HexagonSanDiego
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<FloorPlan, GetFloorPlanDto>();
            CreateMap<AddFloorPlanDto, FloorPlan>();
            CreateMap<UpdateFloorPlanDto, FloorPlan>();

        }
    }
            
}
