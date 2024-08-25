using kruston_api.Model;
using kruston_api.Service;
using Microsoft.AspNetCore.Mvc;

namespace kruston_api.Controllers
{
    [ApiController]
    [Route("api/")]
    public class AuthController : ControllerBase
    {
        private AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<string> Login([FromBody]User user)
        {
            string token = await _authService.Login(user);
            return token;
        }
    }
}
