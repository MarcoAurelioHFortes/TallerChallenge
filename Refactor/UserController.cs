using Microsoft.AspNetCore.Mvc;
using Refactor.Interface;

namespace Refactor
{
    [Route("User")]
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> WelcomeUser(string user)
        {
            try
            {
                var response = await _userService.WelcomeUser(user);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest("Error");
            }
        }
    }
}
