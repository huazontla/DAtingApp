using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Dtos;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto  userForRegisterDto)
        {
            // validate password
            userForRegisterDto.Username = userForRegisterDto.Username.ToLower();

            // validate if the user exist
            if(await _repo.UserExist(userForRegisterDto.Username))
                return BadRequest("User already exist");

            // create the new user
            var userToCreate = new User
            {
                Username = userForRegisterDto.Username 
            };

            // add data to the bd with EF

            var createdUser = await _repo.Register(userToCreate, userForRegisterDto.Password);

            return StatusCode(201);
    
        }


    }
}