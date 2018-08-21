using S2IT.LocadoraGames.Domain.Entities.Geografia;
using S2IT.LocadoraGames.Domain.Interfaces.Repository;
using S2IT.LocadoraGames.Domain.Interfaces.Services;

namespace S2IT.LocadoraGames.Domain.Services
{
    public class CidadeService : ServiceBase<Cidade>, ICidadeService
    {
        public CidadeService(IRepository<Cidade> repository) : base(repository)
        {
        }
    }
}
