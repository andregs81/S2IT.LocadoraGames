using System.Collections.Generic;

namespace S2IT.LocadoraGames.Domain.Entities.Geografia
{
    public class Estado
    {
        public string UF { get; set; }
        public string Nome { get; set; }

        public virtual IEnumerable<Cidade> Cidades { get; set; }
    }
}