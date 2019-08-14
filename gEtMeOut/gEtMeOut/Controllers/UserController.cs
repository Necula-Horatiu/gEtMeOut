using Microsoft.AspNetCore.Mvc;
using gEtMeOut.Services;
using gEtMeOut.Models;
using Microsoft.Extensions.Logging;

namespace gEtMeOut.Controllers
{
    [Route("api/user")]
    public class UserController : Controller
    {
        private IUserService _userService;

        private readonly ILogger _logger;

        public UserController(IUserService userService, ILogger<UserController> logger)
        {
            this._userService = userService;
            this._logger = logger;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetUsers()
        {
            return Ok(_userService.GetUsers());
        }

        [HttpPost]
        [Route("")]
        public IActionResult AddUser([FromBody] User user)
        {
            return Ok(_userService.AddUser(user));
        }

        [HttpPost]
        [Route("login")]
        public IActionResult LoginUser([FromBody] User user)
        {
            var data = _userService.LoginUser(user);
            if (data == null)
            {
                return Ok(0);
            }
            return Ok(data);
        }

    }
}
