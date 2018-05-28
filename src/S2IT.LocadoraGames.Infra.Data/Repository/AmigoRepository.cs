using Dapper;
using Microsoft.EntityFrameworkCore;
using S2IT.LocadoraGames.Domain.Entities.Amigos;
using S2IT.LocadoraGames.Domain.Entities.Jogos;
using S2IT.LocadoraGames.Domain.Interfaces;
using S2IT.LocadoraGames.Domain.Interfaces.Repository;
using S2IT.LocadoraGames.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S2IT.LocadoraGames.Infra.Data.Repository
{
    public class AmigoRepository : Repository<Amigo>, IAmigoRepository
    {
        public AmigoRepository(LocadoraGamesContext context) : base(context)
        {

        }

        public override IEnumerable<Amigo> GetAll()
        {
            var sql = "SELECT * FROM AMIGO(NOLOCK) ORDER BY NOME ";

            return Db.Database.GetDbConnection().Query<Amigo>(sql);
        }

        public override Amigo GetById(int id)
        {

            var sql = "SELECT * " +
            "FROM AMIGO(NOLOCK) A " +
            "LEFT JOIN JOGOS(NOLOCK) J " +
            "ON A.AMIGOID = J.AMIGOID " +
            "WHERE A.AMIGOID = @uid";

            var amigo = Db.Database.GetDbConnection().Query<Amigo, Jogo, Amigo>(sql,
                (a, j) =>
                {
                    if (j != null)
                        a.Jogos.Add(j);
                    return a;
                }, new { uid = id },
                splitOn: "AmigoId, JogoId");

            return amigo.FirstOrDefault();
        }
    }
}
