using System.Collections.Generic;

namespace HexagonSanDiego.Models
{
    public class HomePageDataModel
    {
        public int Id { get; set; }
        public string SliderText { get; set; }
        public string SliderSubText { get; set; }
        public string SliderImage { get; set; }
        public string WelcometoText { get; set; }
        public string WelcometoImage { get; set; }
        public string PhotogalleryText { get; set; }
        public string PhotogalleryImage { get; set; }
        public string AmenitiesText { get; set; }
        public string CommunityText { get; set; }
        public string FooterText { get; set; }
        public string FacebookLink { get; set; }
        public string InstergramLink { get; set; }
        public string YellpLink { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}
