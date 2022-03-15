using HexagonSanDiego.Dtos.FloorPlanDtos;
using HexagonSanDiego.Repositories.IRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HexagonSanDiego.Repositories.Repository
{
    public class FloorPlanRepository : IFloorPlanRepository
    {
        public Task<IEnumerable<GetFloorPlanDto>> AddFloorPlan(AddFloorPlanDto newFloorPlan)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<GetFloorPlanDto>> GetFloorPlan()
        {
            throw new System.NotImplementedException();
        }
    }
}
