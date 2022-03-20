using HexagonSanDiego.Models;
using HexagonSanDiego.Repositories.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace HexagonSanDiego.Pages.AdminPages
{
    public class VertualToursModel : PageModel
    {
        private readonly IVertualToursRepository _vertualToursRepository;

        [BindProperty]

        public VertualTours vertualTours { get; set; }

        public List<VertualTours> allVertualTours = new List<VertualTours>();

        public VertualToursModel(IVertualToursRepository vertualToursRepository)
        {
            _vertualToursRepository = vertualToursRepository;
        }
        public void OnGet()
        {
          //  allVertualTours = _vertualToursRepository.GetVertualTours().Result;
        }

        public ActionResult OnPost(VertualTours vertualTours)
        {
            var vertialTour = vertualTours;

            if (vertialTour != null)
            {
                if (_vertualToursRepository.AddVertualTour(vertialTour).Result)
                {
                    return Redirect("/VirtualTours");
                };
            }
            return null;
        }
    }
}
