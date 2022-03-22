using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HexagonSanDiego.Repositories.IRepository;
using HexagonSanDiego.Models;


namespace HexagonSanDiego.Pages.AdminPages
{
    public class AccessibilityStatementModel : PageModel
    {
        public void OnGet()
        {
        }

        private readonly IAccessbilityRepository _accessibilityRepository; 

        [BindProperty]
        public Accessbility AccessibilityStat { get; set; }

        public AccessibilityStatementModel(IAccessbilityRepository accessbilityRepository)
        {
            _accessibilityRepository = accessbilityRepository;
        }

        public ActionResult OnPost(Accessbility AccessibilityStat)
        {
            var accessibility = AccessibilityStat;
            if(accessibility != null)
            {
                if(_accessibilityRepository.AddAccessibility(accessibility))
                {
                    return Redirect("/AccessibilityStatement");
                }

            }

            return null;
        }

    }
}
