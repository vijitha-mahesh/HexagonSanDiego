using HexagonSanDiego.Data;
using HexagonSanDiego.Models;
using HexagonSanDiego.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexagonSanDiego.Repositories.Repository
{
    public class LocationRepo : ILocationRepo
    {
        private readonly DataContext _context;

        public LocationRepo(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Location>> GetallLocations()
        {
            return await _context.locations.ToListAsync();
        }

        public Location GetFirstLocation()
        {
            return new Location { Description ="jasdfj",Id = 0,Latitude=12.5,LocationName="afdafd",LocationType="A",Longitude=25.0};
        }
    }
}
