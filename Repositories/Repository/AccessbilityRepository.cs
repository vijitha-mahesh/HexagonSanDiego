using AutoMapper;
using HexagonSanDiego.Data;
using HexagonSanDiego.Models;
using HexagonSanDiego.Repositories.IRepository;
using System.Linq;
using System.Threading.Tasks;

namespace HexagonSanDiego.Repositories.Repository
{
    public class AccessbilityRepository : IAccessbilityRepository
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public AccessbilityRepository(IMapper mapper, DataContext context)
        {

            _context = context;
            _mapper = mapper;

        }
        public bool AddAccessibility(Accessbility accessbility)
        {
            Accessbility Accessbility = _mapper.Map<Accessbility>(accessbility);

            _context.Accessbilities.Add(Accessbility);
            if (_context.SaveChanges() >= 0)
            {
                return true;

            }
            return false;
        }

        public async Task<Accessbility> GetAccessibility()
        {
            var plans = _context.Accessbilities
                      .OrderByDescending(p => p.Id)
                      .FirstOrDefault();
            return plans;
        }

        public Task<bool> UpdateAccessibility(Accessbility accessbility)
        {
            throw new System.NotImplementedException();
        }
    }
}
