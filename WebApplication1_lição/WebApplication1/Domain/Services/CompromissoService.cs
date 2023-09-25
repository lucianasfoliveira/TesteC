using WebApplication1.Domain.Entidades;
using WebApplication1.Domain.InterfaceRepository;

namespace WebApplication1.Domain.Services
{
    public class CompromissoService : ICompromissoService
    {

        private readonly ICompromissoRepository _compromissoRepository;
        public CompromissoService(ICompromissoRepository CompromissoRepository)
        {
            _compromissoRepository = CompromissoRepository;

        }

        public IEnumerable<Compromisso> ListaCompromissos()
        {
            return _compromissoRepository.GetAll();
        }

        public IEnumerable<Compromisso> ListarPorNatureza(string Natureza)
        {
            return _compromissoRepository.GetByNatureza(Natureza);
        }
    }
}
