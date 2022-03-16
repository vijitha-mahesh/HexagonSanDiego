using HexagonSanDiego.Models;

namespace HexagonSanDiego.Repositories.IRepository
{
    public interface IHomePageRepository
    {
        bool addData(HomePage homePage);

        HomePage getData();
    }
}
