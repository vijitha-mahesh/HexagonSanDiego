using HexagonSanDiego.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HexagonSanDiego.Repositories.IRepository
{
    public interface IVertualToursRepository
    {
        public Task<bool> AddVertualTour(VertualTours vertualTours);
        public  Task<List<VertualTours>> GetVertualTours();
    }
}
