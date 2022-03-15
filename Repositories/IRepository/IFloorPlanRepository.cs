using HexagonSanDiego.Dtos.FloorPlanDtos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HexagonSanDiego.Repositories.IRepository
{
    public interface IFloorPlanRepository
    {
        Task<IEnumerable<GetFloorPlanDto>> AddFloorPlan (AddFloorPlanDto newFloorPlan);
        Task<IEnumerable<GetFloorPlanDto>> GetFloorPlan();
        Task<IEnumerable<GetFloorPlanDto>> UpdateFloorPlan(UpdateFloorPlanDto updateFloorPlanDto);
        Task<IEnumerable<GetFloorPlanDto>> DeleteFloorPlan(UpdateFloorPlanDto updateFloorPlanDto);

    }
}
