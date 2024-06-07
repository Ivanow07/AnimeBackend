using Microsoft.AspNetCore.Mvc;
using AnimeBackend.Models;
using AnimeBackend.Services;

namespace AnimeBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserService _userService;

        public AuthController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User user)
        {
            if (_userService.ValidateUser(user.Username, user.Password))
            {
                return Ok();
            }
            return Unauthorized();
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] User user)
        {
            if (_userService.CreateUser(user))
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
