using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexagonSanDiego.Dtos.FloorPlanDtos;
using HexagonSanDiego.Repositories.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HexagonSanDiego.Pages
{
    public class EbrochureModel : PageModel
    {
        private readonly IFloorPlanRepository _floorPlanRepository;


        [BindProperty]
        public AddFloorPlanDto addFloorPlanDto { get; set; }

        public List<GetFloorPlanDto> allFloorPlans = new List<GetFloorPlanDto>();


        public EbrochureModel(IFloorPlanRepository floorPlanRepository)
        {
            _floorPlanRepository = floorPlanRepository;

        }
        public void OnGet()
        {
            allFloorPlans = _floorPlanRepository.GetFloorPlan().Result;
        }
    }
}
