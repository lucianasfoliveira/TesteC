using WebApplication1.Domain.Entidades;

namespace WebApplication1.Domain.Services
{
    public interface ICompromissoService
    {
        IEnumerable<Compromisso> ListaCompromissos();

        IEnumerable<Compromisso> ListarPorNatureza(string Natureza);

    }
}
