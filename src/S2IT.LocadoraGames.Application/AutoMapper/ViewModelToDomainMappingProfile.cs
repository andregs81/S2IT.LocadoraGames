using AutoMapper;
using S2IT.LocadoraGames.Application.ViewModels;
using S2IT.LocadoraGames.Domain.Entities.Amigos;
using S2IT.LocadoraGames.Domain.Entities.Jogos;

namespace S2IT.LocadoraGames.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AmigoViewModel, Amigo>();
            CreateMap<JogoViewModel, Jogo>();
        }
    }
}
