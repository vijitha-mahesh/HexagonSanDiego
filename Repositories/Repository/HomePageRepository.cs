using HexagonSanDiego.Data;
using HexagonSanDiego.Models;
using HexagonSanDiego.Repositories.IRepository;

namespace HexagonSanDiego.Repositories.Repository
{

    public class HomePageRepository: IHomePageRepository
    {
        private readonly DataContext _context;
        public HomePageRepository(DataContext context)
        {
            _context = context;
        }

        public bool addData(HomePage homePage)
        {
            _context.HomePages.Add(homePage);
            _context.SaveChanges();
            return true;    
        }

        public HomePage getData()
        {
            HomePage homePage = new HomePage();
            //  _context.HomePages
            return homePage;
        }
    }
}
