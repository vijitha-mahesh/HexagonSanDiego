using HexagonSanDiego.Dtos.FloorPlanDtos;
using HexagonSanDiego.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HexagonSanDiego.Repositories.IRepository
{
    public interface IFloorPlanRepository
    {
        Task<bool> AddFloorPlan (AddFloorPlanDto newFloorPlan);
        //  List<GetFloorPlanDto> GetFloorPlan();
        Task<List<GetFloorPlanDto>> GetFloorPlan();

       // Task<ServiceResponse<List<GetFloorPlanDto>>> GetFloorPlan();


        Task<IEnumerable<GetFloorPlanDto>> UpdateFloorPlan(UpdateFloorPlanDto updateFloorPlanDto);
        Task<IEnumerable<GetFloorPlanDto>> DeleteFloorPlan(UpdateFloorPlanDto updateFloorPlanDto);

    }
}
