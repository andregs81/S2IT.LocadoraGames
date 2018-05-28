using S2IT.LocadoraGames.Application.ViewModels;
using System.Collections.Generic;

namespace S2IT.LocadoraGames.Application.Interfaces
{
    public interface IJogoAppService
    {
        void Add(JogoViewModel jogoViewModel);
        IEnumerable<JogoViewModel> GetAll();
        IEnumerable<JogoViewModel> GetGamesAndFriends();
        JogoViewModel GetById(int id);
        void Update(JogoViewModel jogoViewModel);
        void Devolver(JogoViewModel jogoViewModel);
        void Remove(int id);
        IEnumerable<JogoViewModel> GetByTitle(string title);
    }
}
