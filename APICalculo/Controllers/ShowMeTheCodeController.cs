using APICalculo;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
namespace APICalculaJuros.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ShowMeTheCodeController : ControllerBase
    {
        private string urlGitHub = "https://github.com/MayCris/DesafioTecnico";

        [HttpGet()]
        public string ShowMeTheCode()
        {
            return urlGitHub;
        }
    }
}
