using HexagonSanDiego.Dtos.ContactUsDto;
using HexagonSanDiego.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HexagonSanDiego.Repositories.IRepository
{
    public interface IContactUsRepository
    {
        Task<bool> AddContactUs(ContactUsDto contactUs);
       
        Task<ContactUs> GetContactUs();

        Task<bool> UpdateContactUS(ContactUs contactUs);
    }
}
