using HexagonSanDiego.Dtos.AmenityDtos;
using HexagonSanDiego.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HexagonSanDiego.Repositories.IRepository
{
    public interface IAmenityRepository
    {
        bool AddAmenity(AddAmenityDto addAmenity);
        
        Task<List<Amenity>> GetAmenity();
        bool UpdateAmenity(Amenity amenity);
        bool DeleteAmenity(Amenity amenity);
    }
}
