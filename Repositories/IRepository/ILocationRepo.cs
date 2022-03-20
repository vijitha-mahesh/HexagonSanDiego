using HexagonSanDiego.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HexagonSanDiego.Repositories.IRepository
{
    public interface ILocationRepo
    {
       Task< IEnumerable<Location>> GetallLocations();
        Location GetFirstLocation();
    }
}
