using HexagonSanDiego.Models;
using HexagonSanDiego.Repositories.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HexagonSanDiego.Pages.AdminPages
{
    public class MapAdmin : PageModel
    {
        private readonly ILocationRepo _repo;

        public MapAdmin(ILocationRepo repo)
        {
            _repo = repo;

        }

       [BindProperty]
        public Location location { get; set; }
        public void OnGet()
        {
        }

        public ActionResult OnPost()
        {
            var locationresult = location;

            if (locationresult != null)
            {
                switch (locationresult.LocationType)
                {
                    case "Entertainment": 
                        locationresult.IconUrl = "https://maps.google.com/mapfiles/kml/shapes/library_maps.png";
                        break;

                    case "Food":
                        locationresult.IconUrl = "https://maps.google.com/mapfiles/kml/shapes/library_maps.png";
                        break;

                    case "ShopAndService":
                        locationresult.IconUrl = "https://maps.google.com/mapfiles/kml/shapes/library_maps.png";
                        break;

                    case "NightLife":
                        locationresult.IconUrl = "https://maps.google.com/mapfiles/kml/shapes/library_maps.png";
                        break;

                    case "Recreation":
                        locationresult.IconUrl = "https://maps.google.com/mapfiles/kml/shapes/library_maps.png";
                        break;

                    case "Professional":
                        locationresult.IconUrl = "https://maps.google.com/mapfiles/kml/shapes/library_maps.png";
                        break;

                    case "Traval":
                        locationresult.IconUrl = "https://maps.google.com/mapfiles/kml/shapes/library_maps.png";
                        break;

                    default:
                        break;
                }


               if (_repo.createLocation(locationresult))
                {
                    return Redirect("/MapAdmin");
                }
            }

            return null;
        }
    }
}
