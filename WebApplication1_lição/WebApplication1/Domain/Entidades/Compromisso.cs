namespace WebApplication1.Domain.Entidades
{
    public class Compromisso
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Natureza { get; set; }

        public string Periodicidade { get; set; }

        public bool Ativo { get; set; }

        public DateTime Data { get; set; }

    }
}
