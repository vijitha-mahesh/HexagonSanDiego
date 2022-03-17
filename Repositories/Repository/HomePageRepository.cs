using HexagonSanDiego.Data;
using HexagonSanDiego.Models;
using HexagonSanDiego.Repositories.IRepository;

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
            HomePageDataModel homePage = new HomePageDataModel();
            //  _context.HomePages
            return homePage;
        }
    }
}
