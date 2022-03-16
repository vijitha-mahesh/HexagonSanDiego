using HexagonSanDiego.Dtos.FloorPlanDtos;
using HexagonSanDiego.Repositories.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HexagonSanDiego.Controllers
{
    public class FloorPlanController : Controller
    {
        private readonly IFloorPlanRepository _floorPlanRepository;

        public FloorPlanController(IFloorPlanRepository floorPlanRepository)
        {
            _floorPlanRepository = floorPlanRepository;

        }
        public async Task<IActionResult> Add(AddFloorPlanDto addFloorPlan)
        {
            return Ok(await _floorPlanRepository.AddFloorPlan(addFloorPlan));
        }

        public async Task<IActionResult> Get()
        {
            return Ok(await _floorPlanRepository.GetFloorPlan());
        }
    }
}
