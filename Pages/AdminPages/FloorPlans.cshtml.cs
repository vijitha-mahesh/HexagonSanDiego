using HexagonSanDiego.Dtos.FloorPlanDtos;
using HexagonSanDiego.Models;
using HexagonSanDiego.Repositories.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace HexagonSanDiego.Pages.AdminPages
{
    public class FloorPlansModel : PageModel
    {
        private readonly IFloorPlanRepository _floorPlanRepository;


        [BindProperty]
        public AddFloorPlanDto addFloorPlanDto { get; set; }

        public List<GetFloorPlanDto> allFloorPlans = new List<GetFloorPlanDto>();
        public FloorPlansModel(IFloorPlanRepository floorPlanRepository)
        {
           _floorPlanRepository = floorPlanRepository;
         
        }

        public void OnGet()
        {
            allFloorPlans = _floorPlanRepository.GetFloorPlan().Result;
           
        }

        public ActionResult OnPost(AddFloorPlanDto addFloorPlanDto)
        {
            var floorPlanDto = addFloorPlanDto;

            if (floorPlanDto != null)
            {
               if(_floorPlanRepository.AddFloorPlan(floorPlanDto).Result)
                {
                 return Redirect("/FloorPlans");
                };
            }

            return null;
        }
    }
}
