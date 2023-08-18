using ApiAuthentication.Models;
using ApiAuthentication.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Validations;

namespace ApiAuthentication.Controllers
{
    [ApiController]
    [Route("v1")]
    public class LoginController : Controller
    {
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> AuthenticateAsync([FromBody] User model)
        {

            var user=UserRepository.Get(model.UserName,model.Password);

            if (user == null)
            return NotFound(new {message="Utilizador ou palavra-passe inválidas"});
            //Gera o Token
            var tokenstring=TokenService.GenerateToken(user);
            user.Password = "";
            return new
            {
                user = user,
                token = tokenstring
            };
        }
    }
}
