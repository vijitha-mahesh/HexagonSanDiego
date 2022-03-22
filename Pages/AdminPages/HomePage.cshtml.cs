using HexagonSanDiego.Models;
using HexagonSanDiego.Repositories.IRepository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.FileProviders;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HexagonSanDiego.Pages.AdminPages
{
    public class HomePageModel : PageModel
    {
        private readonly IHomePageRepository _homePageRepository;
        private readonly IWebHostEnvironment _iwebhost;
        private readonly IHostingEnvironment env;

        [BindProperty]
        public HomePageDataModel homePageDataModel { get; set; }

        [BindProperty]
        public List<string> ImageList { get; set; }
        public HomePageModel(IHomePageRepository homePageRepository, IWebHostEnvironment iwebhost, IHostingEnvironment env)
        {
            _homePageRepository = homePageRepository;
            _iwebhost = iwebhost;
            this.env = env;

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

        [BindProperty]
        public IFormFile sliderImage { get; set; }
        public IFormFile welcomeImage { get; set; }
        public IFormFile galleryImage { get; set; }

        public async Task<IActionResult> OnPostAsync(HomePageDataModel homePageDataModel)
        {
            //Slider Image Upload
            var sliderimg = Path.Combine(_iwebhost.WebRootPath, "images/slider", sliderImage.FileName);
            var stream1 = new FileStream(sliderimg, FileMode.Create);
            await sliderImage.CopyToAsync(stream1);
            //var path = env.WebRootFileProvider.GetFileInfo("images/gallery/" + sliderImage.FileName)?.PhysicalPath;
            var sliderPath = "images/slider/" + sliderImage.FileName;
            homePageDataModel.SliderImage = sliderPath;

            //Welcome Image Upload
            var welcomeimg = Path.Combine(_iwebhost.WebRootPath, "images/page", welcomeImage.FileName);
            var stream2 = new FileStream(welcomeimg, FileMode.Create);
            await welcomeImage.CopyToAsync(stream2);
            var welcomePath = "images/page/" + welcomeImage.FileName;
            homePageDataModel.WelcometoImage = welcomePath;

            //Gallery Image Upload
            var galleryimg = Path.Combine(_iwebhost.WebRootPath, "images/page", galleryImage.FileName);
            var stream3 = new FileStream(galleryimg, FileMode.Create);
            await galleryImage.CopyToAsync(stream3);
            var galleryPath = "images/page/" + galleryImage.FileName;
            homePageDataModel.PhotogalleryImage = galleryPath;





            var homePageData = homePageDataModel;

            if (homePageData != null)
            {
                _homePageRepository.addData(homePageData);
            }

            return Page();
        }
    }
}