using S2IT.LocadoraGames.Domain.Entities.Geografia;
using System.Linq;

namespace S2IT.LocadoraGames.Domain.Interfaces.Repository
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        IQueryable<Endereco> GetAll();
    }
}
