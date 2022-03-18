using AutoMapper;
using HexagonSanDiego.Data;
using HexagonSanDiego.Dtos.PolicyDto;
using HexagonSanDiego.Models;
using HexagonSanDiego.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HexagonSanDiego.Repositories.Repository
{
    public class PolicyRepository : IPolicyRepository
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public PolicyRepository(IMapper mapper, DataContext context)
        {

            _context = context;
            _mapper = mapper;

        }
        public async Task<bool> AddPolicy(PolicyDto policy)
        {
            Policy Policy = _mapper.Map<Policy>(policy);

            _context.Policies.Add(Policy);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Policy> GetPolicy()
        {
            var plans = _context.Policies
                      .OrderByDescending(p => p.Id)
                      .FirstOrDefault();
            return plans;
        }

        public async Task<bool> UpdatePolicy(Policy cpolicy)
        {
            try
            {
                Policy Policy = await _context.Policies

                    .FirstOrDefaultAsync(c => c.Id == cpolicy.Id);


                Policy.Title = cpolicy.Title;
                Policy.Description = cpolicy.Description;


                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
