using HexagonSanDiego.Models;
using System.Collections.Generic;

namespace HexagonSanDiego.Dtos.AmenityDtos
{
    public class AddAmenityDto
    {
        public string Name { get; set; }
        public List<Image> Images { get; set; }
    }
}
