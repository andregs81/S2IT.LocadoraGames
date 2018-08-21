using System.Linq;
using S2IT.LocadoraGames.Domain.Entities.Geografia;
using S2IT.LocadoraGames.Domain.Interfaces.Repository;
using S2IT.LocadoraGames.Infra.Data.Context;

namespace S2IT.LocadoraGames.Infra.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(LocadoraGamesContext context) : base(context)
        {
        }

        IQueryable<Endereco> IEnderecoRepository.GetAll()
        {
            return DbSet.AsQueryable();
        }
    }
}
