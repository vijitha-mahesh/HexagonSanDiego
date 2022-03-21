using HexagonSanDiego.Dtos.TermsDto;
using HexagonSanDiego.Repositories.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HexagonSanDiego.Pages.AdminPages
{
    public class TermsAndConditionsModel : PageModel
    {
        public void OnGet()
        {
        }

        private readonly ITermsRepository _termsRepository;

        [BindProperty]
        public TermsDto Terms { get; set; }

        public TermsAndConditionsModel(ITermsRepository termsRepository)
        {
            _termsRepository = termsRepository;
        }

        public ActionResult OnPost()
        {
            var terms = Terms;
            if (terms != null)
            {
                if (_termsRepository.AddTerm(terms))
                {
                    return Redirect("/TermsAndConditions");
                }
            }

            return null;

        }


    }
}
