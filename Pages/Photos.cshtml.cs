using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.FileProviders;

namespace HexagonSanDiego.Pages
{
    public class PhotosModel : PageModel
    {
        //public void OnGet()
        //{
        //}

        private readonly IWebHostEnvironment _iwebhost;

        public PhotosModel(IWebHostEnvironment iwebhost)
        {

            _iwebhost = iwebhost;

        }

        [BindProperty]
        public List<string> ImageList { get; set; }

        public IActionResult OnGet()
        {
            var provider = new PhysicalFileProvider(_iwebhost.WebRootPath);
            var contents = provider.GetDirectoryContents(Path.Combine("images/gallery"));
            var objFiles = contents.OrderBy(m => m.LastModified);

            ImageList = new List<string>();
            foreach (var item in objFiles.ToList())
            {
                ImageList.Add(item.Name);
            }
            return Page();

        }

       


    }
}
