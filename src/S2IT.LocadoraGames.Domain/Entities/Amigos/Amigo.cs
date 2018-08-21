using S2IT.LocadoraGames.Domain.Entities.Geografia;
using S2IT.LocadoraGames.Domain.Entities.Jogos;
using System;
using System.Collections.Generic;
using System.Text;

namespace S2IT.LocadoraGames.Domain.Entities.Amigos
{
    public class Amigo
    {
        protected Amigo()
        {
            Jogos = new List<Jogo>();            
        }        
        public int AmigoId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Apelido { get; set; }
        public string Celular { get; set; }
        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual ICollection<Jogo> Jogos { get; set; }

    }
}
