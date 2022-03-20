using AutoMapper;
using HexagonSanDiego.Data;
using HexagonSanDiego.Dtos.ContactUsDto;
using HexagonSanDiego.Models;
using HexagonSanDiego.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexagonSanDiego.Repositories.Repository
{
    public class ContactUsRepository : IContactUsRepository
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public ContactUsRepository(IMapper mapper, DataContext context)
        {

            _context = context;
            _mapper = mapper;

        }
        public async Task<bool> AddContactUs(ContactUsDto contactUs)
        {
            ContactUs ContactUs = _mapper.Map<ContactUs>(contactUs);

            _context.ContactUss.Add(ContactUs);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<ContactUs> GetContactUs()
        {
            //var plans = await _context.ContactUss.
            //    ToListAsync();
            //return plans;
            var plans = _context.ContactUss
                       .OrderByDescending(p => p.Id)
                       .FirstOrDefault();
            return plans;
        }

            public async Task<bool> UpdateContactUS(ContactUs contactUs)
        {
            try
            {
                ContactUs ContactUs = await _context.ContactUss

                    .FirstOrDefaultAsync(c => c.Id == contactUs.Id);


                ContactUs.Address = contactUs.Address;
                ContactUs.ContactNum = contactUs.ContactNum;
                ContactUs.Day1 = contactUs.Day1;
                ContactUs.Day2 = contactUs.Day2;
                ContactUs.Day3 = contactUs.Day3;
                ContactUs.Day4 = contactUs.Day4;
                ContactUs.Day5= contactUs.Day5;

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
