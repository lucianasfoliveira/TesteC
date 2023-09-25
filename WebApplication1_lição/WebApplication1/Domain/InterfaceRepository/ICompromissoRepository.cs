using System.Collections.Generic;
using WebApplication1.Domain.Entidades;

namespace WebApplication1.Domain.InterfaceRepository
{
    public interface ICompromissoRepository
    {
        IEnumerable<Compromisso> GetAll();

        IEnumerable<Compromisso> GetByNatureza(string Natureza);

    }
}
