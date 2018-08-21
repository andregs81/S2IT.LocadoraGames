using S2IT.LocadoraGames.Domain.Entities.Geografia;
using S2IT.LocadoraGames.Domain.Interfaces.Repository;
using S2IT.LocadoraGames.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace S2IT.LocadoraGames.Domain.Services
{
    public class EnderecoService : ServiceBase<Endereco>, IEnderecoService
    {
        public EnderecoService(IRepository<Endereco> repository) : base(repository)
        {
        }
    }
}
