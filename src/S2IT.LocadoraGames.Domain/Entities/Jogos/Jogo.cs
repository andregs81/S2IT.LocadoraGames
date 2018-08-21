using S2IT.LocadoraGames.Domain.Entities.Amigos;
using System;
using System.Collections.Generic;
using System.Text;

namespace S2IT.LocadoraGames.Domain.Entities.Jogos
{
    public class Jogo
    {
        public int JogoId { get; set; }
        public string Titulo { get; set; }
        public DateTime? DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public int? AmigoId { get; set; }
        public virtual Amigo Amigo { get; set; }

        public bool Disponivel()
        {
            return string.IsNullOrEmpty(this.AmigoId.ToString());
        }

        protected Jogo()
        {

        }
    }
}
