using System.Collections.Generic;
using S2IT.LocadoraGames.Domain.Entities.Jogos;
using S2IT.LocadoraGames.Domain.Interfaces.Repository;
using S2IT.LocadoraGames.Domain.Interfaces.Services;

namespace S2IT.LocadoraGames.Domain.Services
{
    public class JogoService : ServiceBase<Jogo>, IJogoService
    {
        public JogoService(IRepository<Jogo> repository) : base(repository)
        {
        }

        public void Devolver(Jogo jogo)
        {
            jogo.DataEmprestimo = null;
            jogo.AmigoId = null;

            Update(jogo);
        }

        public IEnumerable<Jogo> GetGamesAndFriends()
        {
            return this.GetGamesAndFriends();
        }
    }
}
