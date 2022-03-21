using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HexagonSanDiego.Dtos.PolicyDto;
using HexagonSanDiego.Repositories.IRepository;

namespace HexagonSanDiego.Pages.AdminPages
{
    public class PrivacyPolicyModel : PageModel
    {
        public void OnGet()
        {
        }

        private readonly IPolicyRepository _policyRepository;

        [BindProperty]
        public PolicyDto Policy { get; set; }

        public PrivacyPolicyModel(IPolicyRepository policyRepository)
        {
            _policyRepository = policyRepository;
        }

        public ActionResult OnPost()
        {
            var policy = Policy;
            if (policy != null)
            {
                if (_policyRepository.AddPolicy(policy)) 
                {
                    return Redirect("/PrivacyPolicy");
                }
            }

            return null;

        }
    }

        
}
