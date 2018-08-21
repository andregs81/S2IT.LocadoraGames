using S2IT.LocadoraGames.Application.ViewModels;
using S2IT.LocadoraGames.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace S2IT.LocadoraGames.Application.Interfaces
{
    public interface IEnderecoAppService : IDisposable
    {
        IEnumerable<CidadeViewModel> ObterCidades();        
    }
}
