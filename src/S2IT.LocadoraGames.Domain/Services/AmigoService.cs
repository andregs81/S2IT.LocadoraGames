using S2IT.LocadoraGames.Domain.Entities.Amigos;
using S2IT.LocadoraGames.Domain.Interfaces.Repository;
using S2IT.LocadoraGames.Domain.Interfaces.Services;

namespace S2IT.LocadoraGames.Domain.Services
{
    public class AmigoService : ServiceBase<Amigo>, IAmigoService
    {
        public AmigoService(IRepository<Amigo> repository) : base(repository)
        {
        }
    }
}
    