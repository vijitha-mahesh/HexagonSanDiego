namespace HexagonSanDiego.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public Amenity Amenity { get; set; }
        public HomePage HomePage { get; set; }
    }
}
