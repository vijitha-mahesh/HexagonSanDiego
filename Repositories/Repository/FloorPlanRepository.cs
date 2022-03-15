using AutoMapper;
using HexagonSanDiego.Data;
using HexagonSanDiego.Dtos.FloorPlanDtos;
using HexagonSanDiego.Models;
using HexagonSanDiego.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexagonSanDiego.Repositories.Repository
{
    public class FloorPlanRepository : IFloorPlanRepository
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
     
        public FloorPlanRepository(IMapper mapper, DataContext context)
        {
           
            _context = context;
            _mapper = mapper;

        }
        public async Task<IEnumerable<GetFloorPlanDto>> AddFloorPlan(AddFloorPlanDto newFloorPlan)
        {
            FloorPlan floorPlan  = _mapper.Map<FloorPlan>(newFloorPlan);
           
            _context.FloorPlans.Add(floorPlan);
            await _context.SaveChangesAsync();
            var result = await _context.FloorPlans.ToListAsync();
            return (IEnumerable<GetFloorPlanDto>)result;
        }

        public async Task<IEnumerable<GetFloorPlanDto>> GetFloorPlan()
        {
            var plans = await _context.FloorPlans.ToArrayAsync();
            var x = plans.Select(c => _mapper.Map<GetFloorPlanDto>(c)).ToList();
            return x;
        }
    }
}
