using HexagonSanDiego.Models;
using HexagonSanDiego.Repositories.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexagonSanDiego.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHomePageRepository _homePageRepository;

        [BindProperty]
        public HomePageDataModel homePageDataModel { get; set; }

        //public HomePageDataModel homePagedata = new HomePageDataModel();

        public IndexModel(ILogger<IndexModel> logger, IHomePageRepository homePageRepository)
        {
            _logger = logger;
            _homePageRepository = homePageRepository;
        }

        public void OnGet()
        {
           homePageDataModel = _homePageRepository.getData();
        }
    }
}
