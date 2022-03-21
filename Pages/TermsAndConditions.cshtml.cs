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
    public class TermsAndConditionsModel : PageModel
    {
        private readonly ITermsRepository _termsRepository;

        public TermsAndConditionsModel(ITermsRepository termsRepository)
        {
            _termsRepository = termsRepository;
        }

        [BindProperty]
        public Term termsAndConditionsModel { get; set; }

        public void OnGet()
        {
            termsAndConditionsModel = _termsRepository.GetTerm().Result;

        }
    }
}
