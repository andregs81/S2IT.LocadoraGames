using S2IT.LocadoraGames.Domain.Entities.Geografia;
using S2IT.LocadoraGames.Domain.Interfaces.Repository;
using S2IT.LocadoraGames.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace S2IT.LocadoraGames.Infra.Data.Repository
{
    public class CidadeRepository : Repository<Cidade>, ICidadeRepository
    {
        public CidadeRepository(LocadoraGamesContext context) : base(context)
        {
        }
    }
}
