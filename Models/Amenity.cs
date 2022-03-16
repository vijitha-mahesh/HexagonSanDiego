using System.Collections.Generic;

namespace HexagonSanDiego.Models
{
    public class Amenity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Image> Images { get; set; }
    }
}
