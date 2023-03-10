using APITaxas.Classes;
using Microsoft.AspNetCore.Mvc;

namespace APITaxas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class TaxasController : ControllerBase
    {
        [HttpGet]
        public decimal GetTaxaJuros()
        {
            TaxaJuros taxaJuros = new TaxaJuros();
            return taxaJuros.ConsultaTaxaJuros();
        }
    }
}
