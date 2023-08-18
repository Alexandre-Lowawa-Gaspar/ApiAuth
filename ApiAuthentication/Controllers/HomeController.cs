using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiAuthentication.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("anounymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => $"Autenticado-{0}- {User.Identity.Name}";
        [HttpGet]
        [Route("Villa")]
        [Authorize(Roles = "Hokage,Jinnjurike")]
        public string Ninja() => "Ninjas da Aldeia Oculta";
        [HttpGet]
        [Route("Hokage")]
        [Authorize(Roles = "Hokage")]
        public string Hokage() => "És um Hokage";

    }
}
