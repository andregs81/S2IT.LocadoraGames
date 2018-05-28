using S2IT.LocadoraGames.Domain.Entities.Jogos;
using System.Collections.Generic;

namespace S2IT.LocadoraGames.Domain.Interfaces.Services
{
    public interface IJogoService : IServiceBase<Jogo>
    {
        IEnumerable<Jogo> GetGamesAndFriends();
        void Devolver(Jogo jogo);
    }
}
