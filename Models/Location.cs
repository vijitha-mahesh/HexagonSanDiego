namespace HexagonSanDiego.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Description { get; set; }
        public string LocationType { get; set; }
        public string IconUrl { get; set; }
    }
}
