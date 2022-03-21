using HexagonSanDiego.Dtos.PolicyDto;
using HexagonSanDiego.Models;
using System.Threading.Tasks;

namespace HexagonSanDiego.Repositories.IRepository
{
    public interface IPolicyRepository
    {
        bool AddPolicy(PolicyDto policy);

        Task<Policy> GetPolicy();

        Task<bool> UpdatePolicy(Policy cpolicy);
    }
}
