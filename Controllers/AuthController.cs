using HexagonSanDiego.Dtos.UserDtos;
using HexagonSanDiego.Model;
using HexagonSanDiego.Models;
using HexagonSanDiego.Repositories.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HexagonSanDiego.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;

        }
        [HttpGet]
        public ActionResult xxx()
        {
            return Ok("xxx");
        }

        [HttpPost("Login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDto request)
        {

            var response = await _authRepo.Login(
                request.Email, request.Password
            );

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var response = await _authRepo.Register(
                new User
                {
                    Role = request.Role,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Email = request.Email,
                     DoorNumber = request.DoorNumber,
                     Street = request.Street,
                     City = request.City

                   }
                , request.Password
            );

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}
