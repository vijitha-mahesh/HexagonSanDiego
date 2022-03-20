using HexagonSanDiego.Data;
using HexagonSanDiego.Models;
using HexagonSanDiego.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexagonSanDiego.Repositories.Repository
{
    public class VertualToursRepository: IVertualToursRepository
    {
        private readonly DataContext _context;

        public VertualToursRepository(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task<bool> AddVertualTour(VertualTours vertualTours)
        {
            _context.VertualTour.Add(vertualTours);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<VertualTours>> GetVertualTours()
        {
            var tours = await _context.VertualTour.ToListAsync();

            if(tours != null)
            {
                return tours;
            }
            return null;
        }

    }
}