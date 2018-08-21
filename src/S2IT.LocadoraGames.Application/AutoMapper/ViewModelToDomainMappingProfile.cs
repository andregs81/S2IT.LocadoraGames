using AutoMapper;
using S2IT.LocadoraGames.Application.ViewModels;
using S2IT.LocadoraGames.Domain.Entities.Amigos;
using S2IT.LocadoraGames.Domain.Entities.Geografia;
using S2IT.LocadoraGames.Domain.Entities.Jogos;

namespace S2IT.LocadoraGames.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AmigoViewModel, Amigo>();                

            CreateMap<JogoViewModel, Jogo>();

            CreateMap<EnderecoViewModel, Endereco>()
                .ForMember(s => s.Cidade, opt => opt.Ignore());

            CreateMap<AmigoEnderecoViewModel, Amigo>()
                .ForMember(s => s.Jogos, opt => opt.Ignore())
                .ForMember(s => s.Endereco, opt => opt.Ignore());

            CreateMap<AmigoEnderecoViewModel, Endereco>()
                .ForMember(s => s.Cidade, opt => opt.Ignore())
                .ForMember(s => s.Amigo, opt => opt.Ignore());


        }
    }
}
