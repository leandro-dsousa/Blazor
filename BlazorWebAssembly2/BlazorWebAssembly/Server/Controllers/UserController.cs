using BlazorWebAssembly.Server.Domain.Users;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWebAssembly.Server.Controllers
{
    [Route("/[controller]")]
    public class UserController : Controller
    {
        IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet("{username}")]
        public async Task<ActionResult<UserDTO>> GetUserByUsername(string username)
        {
            try
            {
                var user = await userRepository.GetUserByUsername(username);

                if(user == null)
                    return NotFound();
                else
                    return Ok(user);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database.");
            }
        }
    }
}
