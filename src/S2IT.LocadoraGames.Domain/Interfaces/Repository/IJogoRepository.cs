using S2IT.LocadoraGames.Domain.Entities.Jogos;

using System.Collections.Generic;

namespace S2IT.LocadoraGames.Domain.Interfaces.Repository
{
    public interface IJogoRepository : IRepository<Jogo>
    {
        IEnumerable<Jogo> GetGamesAndFriends();
        void Devolver(Jogo jogo);
        IEnumerable<Jogo> GetByTitle(string title);
    }
}
