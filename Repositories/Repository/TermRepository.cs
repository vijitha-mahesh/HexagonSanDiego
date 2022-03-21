using AutoMapper;
using HexagonSanDiego.Data;
using HexagonSanDiego.Dtos.TermsDto;
using HexagonSanDiego.Models;
using HexagonSanDiego.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HexagonSanDiego.Repositories.Repository
{
    public class TermRepository : ITermsRepository
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public TermRepository(IMapper mapper, DataContext context)
        {

            _context = context;
            _mapper = mapper;

        }
        public bool AddTerm(TermsDto terms)
        {
            Term term = _mapper.Map<Term>(terms);

            _context.Terms.Add(term);
            if(_context.SaveChanges() >= 0)
            {
                return true;

            }
            return false;

        }

        public async Task<Term> GetTerm()
        {
            var plans = _context.Terms
                       .OrderByDescending(p => p.Id)
                       .FirstOrDefault();
            return plans;
        }

        public async Task<bool> UpdateTerm(Term term)
        {
            try
            {
                Term Term = await _context.Terms

                    .FirstOrDefaultAsync(c => c.Id == term.Id);


                Term.Title = term.Title;
                Term.Description = term.Description;
                

                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
