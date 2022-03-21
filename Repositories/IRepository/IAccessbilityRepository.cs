using HexagonSanDiego.Models;
using System.Threading.Tasks;

namespace HexagonSanDiego.Repositories.IRepository
{
    public interface IAccessbilityRepository
    {
        bool AddAccessibility(Accessbility accessbility);

        Task<Accessbility> GetAccessibility();

        Task<bool> UpdateAccessibility(Accessbility accessbility);
    }
}
