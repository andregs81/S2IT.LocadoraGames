using S2IT.LocadoraGames.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace S2IT.LocadoraGames.Application.Interfaces
{
    public interface IAmigoAppService : IDisposable
    {
        void Add(AmigoViewModel amigoViewModel);
        IEnumerable<AmigoViewModel> GetAll();        
        AmigoViewModel GetById(int id);
        void Update(AmigoViewModel amigoViewModel);
        void Remove(int id);

    }
}
