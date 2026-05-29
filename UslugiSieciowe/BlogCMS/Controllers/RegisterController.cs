using BlogCMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogCMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RegisterController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register(LoginModel newUser)
        {
            newUser.Role = "Admin";
            UserConstants.Users.Add(newUser);

            return Ok("User registered");
        }
    }
}