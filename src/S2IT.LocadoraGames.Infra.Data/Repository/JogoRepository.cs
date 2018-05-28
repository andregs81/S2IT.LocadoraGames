using System.Collections.Generic;
using Dapper;
using Microsoft.EntityFrameworkCore;
using S2IT.LocadoraGames.Domain.Entities.Amigos;
using S2IT.LocadoraGames.Domain.Entities.Jogos;
using S2IT.LocadoraGames.Domain.Interfaces;
using S2IT.LocadoraGames.Domain.Interfaces.Repository;
using S2IT.LocadoraGames.Infra.Data.Context;

namespace S2IT.LocadoraGames.Infra.Data.Repository
{
    public class JogoRepository : Repository<Jogo>, IJogoRepository
    {
        public JogoRepository(LocadoraGamesContext context) : base(context)
        {
            
        }

        public void Devolver(Jogo jogo)
        {
            jogo.AmigoId = null;
            jogo.DataEmprestimo = null;
            Update(jogo);
        }

        public override IEnumerable<Jogo> GetAll()
        {
            var sql = "SELECT * FROM JOGOS(NOLOCK) ORDER BY TITULO";

            return Db.Database.GetDbConnection().Query<Jogo>(sql);
        }

        public IEnumerable<Jogo> GetByTitle(string title)
        {
            var sql = "SELECT * FROM JOGOS(NOLOCK) WHERE TITULO =@T";
            var jogo = Db.Database.GetDbConnection().Query<Jogo>(sql, new { T = title });
            return jogo;
        }

        public IEnumerable<Jogo> GetGamesAndFriends()
        {
            var sql = "SELECT * " +
            "FROM JOGOS(NOLOCK) J " +
            "LEFT JOIN AMIGO(NOLOCK) A " +
            "ON J.AMIGOID = A.AMIGOID ";

            var jogos = Db.Database.GetDbConnection().Query<Jogo, Amigo, Jogo>(sql,
                (j, a) =>
                {
                    if (j != null)
                        j.Amigo = a;
                    return j;
                },
                splitOn: "AmigoId");

            return jogos;
        }
    }
}
