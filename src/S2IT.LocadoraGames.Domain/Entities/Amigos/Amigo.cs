using S2IT.LocadoraGames.Domain.Entities.Jogos;
using System;
using System.Collections.Generic;
using System.Text;

namespace S2IT.LocadoraGames.Domain.Entities.Amigos
{
    public class Amigo
    {
        public int AmigoId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Apelido { get; set; }
        public string Celular { get; set; }

        public virtual ICollection<Jogo> Jogos { get; set; }


        protected Amigo()
        {
            Jogos = new List<Jogo>();
        }

    }
}
