using HexagonSanDiego.Dtos.AmenityDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HexagonSanDiego.Repositories.IRepository
{
    public interface IAmenityRepository
    {
        Task<IEnumerable<GetAmenityDto>> AddFloorPlan(AddAmenityDto newAmenity);
    }
}
