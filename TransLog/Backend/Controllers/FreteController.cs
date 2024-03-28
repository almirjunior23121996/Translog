
using Backend.Models.Request;

namespace Backend.Controllers
{
    public class FreteController : FreteRequest
    {
        const double ValorFixoPorKm = 0.50;
        const double ValorAdicionalPorKg = 1.00;
        const double ValorAdicionalPorM3 = 2.00;

       
        double custoFrete = (DistanciaEmKm * ValorFixoPorKm) +
                            (PesoEmKg * ValorAdicionalPorKg) +
                            (LarguraEmMetros * AlturaEmMetros * ComprimentoEmMetros * ValorAdicionalPorM3);

    return CustoFrete;
    };
}
    

