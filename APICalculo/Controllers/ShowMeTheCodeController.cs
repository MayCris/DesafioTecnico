using APICalculo;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
namespace APICalculaJuros.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ShowMeTheCodeController : ControllerBase
    {
        private string urlGitHub = "http://localhost:5090/api/taxas";

        [HttpGet()]
        public string ShowMeTheCode()
        {
            return urlGitHub;
        }
    }
}