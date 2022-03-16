using AutoMapper;
using HexagonSanDiego.Data;
using HexagonSanDiego.Dtos.FloorPlanDtos;
using HexagonSanDiego.Models;
using HexagonSanDiego.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
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

        public async Task<IEnumerable<GetFloorPlanDto>> DeleteFloorPlan(UpdateFloorPlanDto updateFloorPlanDto)
        {
            try
            {
                FloorPlan floorPlan = await _context.FloorPlans

                    .FirstOrDefaultAsync(c => c.Id == updateFloorPlanDto.Id);


                floorPlan.Name = updateFloorPlanDto.Name;
                floorPlan.Bed = updateFloorPlanDto.Bed;
                floorPlan.Bath = updateFloorPlanDto.Bath;
                floorPlan.SqFeet = updateFloorPlanDto.SqFeet;
                floorPlan.Rent = updateFloorPlanDto.Rent;
                floorPlan.Deposit = updateFloorPlanDto.Deposit;
                floorPlan.Status = (Status)1;
                floorPlan.Category = updateFloorPlanDto.Category;

                await _context.SaveChangesAsync();
                var list = _mapper.Map<GetFloorPlanDto>(floorPlan);
                return (IEnumerable<GetFloorPlanDto>)list;

            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public async Task<IEnumerable<GetFloorPlanDto>> GetFloorPlan()
        {
            var plans = await _context.FloorPlans.ToArrayAsync();
            var x = plans.Select(c => _mapper.Map<GetFloorPlanDto>(c)).ToList();
            return x;
        }

        public async Task<IEnumerable<GetFloorPlanDto>> UpdateFloorPlan(UpdateFloorPlanDto updateFloorPlanDto)
        {
            try
            {
                FloorPlan floorPlan = await _context.FloorPlans
                   
                    .FirstOrDefaultAsync(c => c.Id == updateFloorPlanDto.Id);


                floorPlan.Name = updateFloorPlanDto.Name;
                floorPlan.Bed = updateFloorPlanDto.Bed;
                floorPlan.Bath = updateFloorPlanDto.Bath;
                floorPlan.SqFeet = updateFloorPlanDto.SqFeet;
                floorPlan.Rent = updateFloorPlanDto.Rent;
                floorPlan.Deposit = updateFloorPlanDto.Deposit;
                floorPlan.Status = 0;
                floorPlan.Category = updateFloorPlanDto.Category;

                await _context.SaveChangesAsync();
                var list = _mapper.Map<GetFloorPlanDto>(floorPlan);
                return (IEnumerable<GetFloorPlanDto>)list;
               
            }
            catch (Exception ex)
            {
                
                return null;
            }
            
        }
    
    }
}
