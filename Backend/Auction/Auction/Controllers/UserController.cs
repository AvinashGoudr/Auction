using Auction.Domain.Modeles;
using Auction.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("GetUserByUserId")]
        public async Task<IActionResult> GetUser(int Id)
        {
            return Ok(await _userService.GetUserByUserId(Id));
        }

        [HttpGet]
        [Route("GetUserByUserName")]
        public async Task<IActionResult> GetUserByUserName(string name)
        {
            return Ok(await _userService.GetUserByUserName(name));
        }

        [HttpPost]
        [Route("AddUser")]
        public async Task<IActionResult> AddUser(UserDetailsDto userDetails)
        {
            return Ok(await _userService.AddUser(userDetails));
        }
    }
}
