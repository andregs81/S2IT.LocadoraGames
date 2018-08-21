using AutoMapper;
using S2IT.LocadoraGames.Application.ViewModels;
using S2IT.LocadoraGames.Domain.Entities.Amigos;
using S2IT.LocadoraGames.Domain.Entities.Geografia;
using S2IT.LocadoraGames.Domain.Entities.Jogos;

namespace S2IT.LocadoraGames.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Amigo, AmigoViewModel>();
            CreateMap<Jogo, JogoViewModel>();

            CreateMap<Endereco, EnderecoViewModel>(MemberList.None);
                
            CreateMap<Amigo, AmigoEnderecoViewModel>(MemberList.None);

            CreateMap<Endereco, AmigoEnderecoViewModel>(MemberList.None);
                
        }
    }
}
