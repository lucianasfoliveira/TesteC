using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.Entidades;
using WebApplication1.Domain.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CompromissoController : ControllerBase
    {
        private readonly ICompromissoService _compromissoService;
        public CompromissoController(ICompromissoService CompromissoService)
        {
            _compromissoService = CompromissoService;
        }

        [HttpGet("/listacompromisso")]
        public IEnumerable<Compromisso> ListaCompromissov2()
        {
            return _compromissoService.ListaCompromissos();
        }

        [HttpGet("/GetNome")]
        public string Get()
        {
            return "Luciana";
        }

        [HttpGet("/Getfilhas")]
        public string GetFilhas()
        {
            return "Stella";
        }

        [HttpGet("/GetNatureza")]
        public IEnumerable<Compromisso> GetNatureza(string Natureza)
        {
            return _compromissoService.ListarPorNatureza(Natureza);
        }
    }
}
