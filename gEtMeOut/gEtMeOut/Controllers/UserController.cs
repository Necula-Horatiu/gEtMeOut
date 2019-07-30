using Microsoft.AspNetCore.Mvc;
using System.Linq;
using gEtMeOut.Data;
using gEtMeOut.Services;
using gEtMeOut.Models;

namespace gEtMeOut.Controllers
{
    [Route("api/user")]
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            this._userService = userService;
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

    }
}
