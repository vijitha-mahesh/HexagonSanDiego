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
    public class VirtualToursModel : PageModel
    {
        private readonly IVertualToursRepository _vertualToursRepository;

        [BindProperty]

        public VertualTours vertualTours { get; set; }

        public List<VertualTours> allVertualTours = new List<VertualTours>();

        public VirtualToursModel(IVertualToursRepository vertualToursRepository)
        {
            _vertualToursRepository = vertualToursRepository;
        }
        public void OnGet()
        {
            allVertualTours = _vertualToursRepository.GetVertualTours().Result;
        }
    }
}
