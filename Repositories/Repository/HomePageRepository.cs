using HexagonSanDiego.Data;
using HexagonSanDiego.Models;
using HexagonSanDiego.Repositories.IRepository;
using System.Linq;

namespace HexagonSanDiego.Repositories.Repository
{
    public class HomePageRepository:IHomePageRepository
    {
        private readonly DataContext _context;
        public HomePageRepository(DataContext context)
        {
            _context = context;
        }

        public bool addData(HomePageDataModel homePage)
        {
            _context.HomePages.Add(homePage);
            _context.SaveChanges();
            return true;
        }

        public HomePageDataModel getData()
        {
         //   var homePage = new HomePageDataModel();
           var homePage = _context.HomePages.OrderByDescending(x => x.Id).Take(1).FirstOrDefault();
            return homePage;
        }
    }
}
