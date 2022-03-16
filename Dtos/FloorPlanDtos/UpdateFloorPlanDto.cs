using HexagonSanDiego.Models;

namespace HexagonSanDiego.Dtos.FloorPlanDtos
{
    public class UpdateFloorPlanDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bed { get; set; }
        public int Bath { get; set; }
        public Category Category { get; set; }
        public int SqFeet { get; set; }
        public string Rent { get; set; }
        public int Deposit { get; set; }
        public string ImageUrl { get; set; }
        public Status Status { get; set; } 
    }
}
