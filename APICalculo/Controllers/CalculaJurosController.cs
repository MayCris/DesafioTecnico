using APICalculo.Classes;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
namespace APICalculaJuros.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CalculaJurosController : ControllerBase
    {
        private string urlApiTaxas = "http://localhost:5090/api/taxas";

        [HttpGet("{valorInicial:decimal},{meses:int}")]
        public string GetCalculaJuros(decimal valorInicial, int meses)
        {
            decimal taxaJuros = this.ConsultarTaxaJuros(); ;

            Retorno retorno = new Retorno();
            retorno.CalcularJuros(valorInicial, meses, taxaJuros);
            
            return string.Concat("R$ ", retorno.Resultado);
       }

        private decimal ConsultarTaxaJuros()
        {
            decimal taxa = 0;
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(urlApiTaxas);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync(urlApiTaxas).Result;

                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    taxa = Newtonsoft.Json.JsonConvert.DeserializeObject<decimal>(result);
                }
            }
            catch
            {
                taxa = 0;
            }

            return taxa;
        }   
       
    }
}
