using HexagonSanDiego.Models;

namespace HexagonSanDiego.Repositories.IRepository
{
    public interface IHomePageRepository
    {
        bool addData(HomePageDataModel homePage);

        HomePageDataModel getData();
    }
}
