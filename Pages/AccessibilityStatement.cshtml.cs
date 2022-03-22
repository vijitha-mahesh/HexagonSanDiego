using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HexagonSanDiego.Repositories.IRepository;
using HexagonSanDiego.Models;

namespace HexagonSanDiego.Pages
{
    public class AccessibilityStatementModel : PageModel
    {
        private readonly IAccessbilityRepository _accessibilityRepository; 
        
        public AccessibilityStatementModel(IAccessbilityRepository accessbilityRepository)
        {
            _accessibilityRepository = accessbilityRepository;
        }

        [BindProperty]
        public Accessbility accessibilityStatementModel { get; set; }

        public void OnGet()
        {
            accessibilityStatementModel = _accessibilityRepository.GetAccessibility().Result;
        }
    }
}
