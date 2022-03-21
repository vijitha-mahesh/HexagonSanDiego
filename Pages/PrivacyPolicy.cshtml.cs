using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HexagonSanDiego.Repositories.IRepository;
using HexagonSanDiego.Models;

namespace HexagonSanDiego.Pages
{
    public class PrivacyPolicyModel : PageModel
    {
        private readonly IPolicyRepository _policyRepositoy;

        public PrivacyPolicyModel(IPolicyRepository policyRepositoy)
        {
            _policyRepositoy = policyRepositoy;
        }

        [BindProperty]
        public Policy privacyPolicyModel { get; set; }

        public void OnGet()
        {
            privacyPolicyModel = _policyRepositoy.GetPolicy().Result;
        }
    }
}
