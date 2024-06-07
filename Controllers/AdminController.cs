using Microsoft.AspNetCore.Mvc;
using AnimeBackend.Models;
using AnimeBackend.Services;

namespace AnimeBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly UserService _userService;

        public AdminController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet("users")]
        public IEnumerable<User> GetUsers()
        {
            return _userService.GetAllUsers();
        }

        [HttpPost("createuser")]
        public IActionResult CreateUser([FromBody] User user)
        {
            if (_userService.CreateUser(user))
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
