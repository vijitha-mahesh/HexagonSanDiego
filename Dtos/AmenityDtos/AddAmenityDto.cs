using HexagonSanDiego.Models;
using System.Collections.Generic;

namespace HexagonSanDiego.Dtos.AmenityDtos
{
    public class AddAmenityDto
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Status { get; set; }
        public bool HasImage { get; set; }
    }
}
