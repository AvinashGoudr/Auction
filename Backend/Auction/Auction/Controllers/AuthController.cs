using Auction.Services.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace Auction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly TokenService _tokenService;

        public AuthController(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User loginRequest)
        {
            if (!string.IsNullOrEmpty(loginRequest.Username) && !string.IsNullOrEmpty(loginRequest.Password))
            {
                var token = _tokenService.GenerateToken(loginRequest.Username);
                return Ok(new { Token = token });
            }
            return Unauthorized();
        }
    }
}
