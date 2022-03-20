using HexagonSanDiego.Models;
using HexagonSanDiego.Repositories.IRepository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HexagonSanDiego.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHomePageRepository _homePageRepository;
        private readonly IWebHostEnvironment _iwebhost;

        [BindProperty]
        public HomePageDataModel homePageDataModel { get; set; }

        [BindProperty]
        public List<string> ImageList { get; set; }

        //public HomePageDataModel homePagedata = new HomePageDataModel();

        public IndexModel(ILogger<IndexModel> logger, IHomePageRepository homePageRepository, IWebHostEnvironment iwebhost)
        {
            _logger = logger;
            _homePageRepository = homePageRepository;
            _iwebhost = iwebhost;
        }

        public void OnGet()
        {
           homePageDataModel = _homePageRepository.getData();

            var provider = new PhysicalFileProvider(_iwebhost.WebRootPath);
            var contents = provider.GetDirectoryContents(Path.Combine("images/slider"));
            var objFiles = contents.OrderBy(m => m.LastModified);

            ImageList = new List<string>();
            foreach (var item in objFiles.ToList())
            {
                ImageList.Add(item.Name);
            }
        }
    }
}
