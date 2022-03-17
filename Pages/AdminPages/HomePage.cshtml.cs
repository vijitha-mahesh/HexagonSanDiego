using HexagonSanDiego.Models;
using HexagonSanDiego.Repositories.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HexagonSanDiego.Pages.AdminPages
{
    public class HomePageModel : PageModel
    {
        private readonly IHomePageRepository _homePageRepository;

        [BindProperty]
        public HomePageDataModel homePageDataModel { get; set; }
        public HomePageModel(IHomePageRepository homePageRepository)
        {
            _homePageRepository = homePageRepository;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost(HomePageDataModel homePageDataModel)
        {
            var homePageData = homePageDataModel;

            if (homePageData != null)
            {
               _homePageRepository.addData(homePageData);
            }
            
            return Page();
        }
    }
}
