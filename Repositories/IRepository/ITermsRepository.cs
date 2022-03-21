using HexagonSanDiego.Dtos.TermsDto;
using HexagonSanDiego.Models;
using System.Threading.Tasks;

namespace HexagonSanDiego.Repositories.IRepository
{
    public interface ITermsRepository
    {
        bool AddTerm(TermsDto terms);

        Task<Term> GetTerm();

        Task<bool> UpdateTerm(Term term);
    }
}
