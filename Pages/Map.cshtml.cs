using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexagonSanDiego.Models;
using HexagonSanDiego.Repositories.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HexagonSanDiego.Pages
{
    public class MapModel : PageModel
    {
        private readonly ILocationRepo _repo;
        [BindProperty]
        public IEnumerable<Location> Locations { get; set; }
        [BindProperty]
        public string mapsrc { get; set; }
        public string selectedMapItem { get; set; }
        public MapModel(ILocationRepo repo)
        {
            _repo =repo;
            mapsrc = "https://maps.googleapis.com/maps/api/js?key=AIzaSyA5XTX9-pSDBAHYCn7h39o9CYluaFs8c-E&callback=initMap";
          
        }
        public async Task OnGetAsync()
        {
          // Locations = await _repo.GetallLocations();
        }

        public async Task<IActionResult> OnGetMapMarkersAsync()
        {  
            Locations = await _repo.GetallLocations();
            return new JsonResult(Locations);
        }
    }
}
