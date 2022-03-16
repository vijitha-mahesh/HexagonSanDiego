using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Threading.Tasks;

namespace HexagonSanDiego.Pages.AdminPages
{
    public class PhotosModel : PageModel
    {
        public void OnGet()
        {
        }

        private readonly IWebHostEnvironment _iwebhost;

        public PhotosModel(IWebHostEnvironment iwebhost)
        {

            _iwebhost = iwebhost;

        }

        [BindProperty]
        public IFormFile ifile { get; set; }

        public  async Task<IActionResult> OnPostAsync()
        {
            var saveimg = Path.Combine(_iwebhost.WebRootPath, "images/gallery", ifile.FileName);
            var stream = new FileStream(saveimg, FileMode.Create);
            await ifile.CopyToAsync(stream);
            ViewData["Message"] = "Image Added Successfully";

            return Page();
        }
    }
}
