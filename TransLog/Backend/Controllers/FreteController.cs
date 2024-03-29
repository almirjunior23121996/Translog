
using Microsoft.AspNetCore.Mvc;
using Backend.Models.Request;
using Backend.Models.Response;

namespace Backend.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class FreteController : ControllerBase
    {
        [HttpGet]
        [Route("obter")]

        public IActionResult CalcularFrete([FromQuery] FreteRequest request) 
        {
            var altura = request.AlturaEmMetros;
            var peso = request.PesoEmKg;
            var distancia = request.DistanciaEmKm;
            var largura = request.LarguraEmMetros;
            var comprimento = request.ComprimentoEmMetros;  
           
            var response = new FreteResponse();

            var valorTotal = (distancia * 0.50) + (peso * 1) + (largura * altura * comprimento * 2);

            response.CustoFrete = valorTotal;
 
            return Ok(response);
        }

        //var response = new FreteRequest();



        //double custoFrete = (DistanciaEmKm * ValorFixoPorKm) +
        //                    (PesoEmKg * ValorAdicionalPorKg) +
        //                    (LarguraEmMetros * AlturaEmMetros * ComprimentoEmMetros * ValorAdicionalPorM3);

        //return custoFrete;
    }
}
    

