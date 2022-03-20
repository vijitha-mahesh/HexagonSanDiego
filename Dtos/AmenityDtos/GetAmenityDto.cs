using HexagonSanDiego.Models;
using System.Collections.Generic;

namespace HexagonSanDiego.Dtos.AmenityDtos
{
    public class GetAmenityDto
    {
        public string Name { get; set; }
        public List<Image> Images { get; set; }
    }
}
