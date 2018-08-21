using AutoMapper;
using S2IT.LocadoraGames.Application.Interfaces;
using S2IT.LocadoraGames.Application.ViewModels;
using S2IT.LocadoraGames.Domain.Entities.Geografia;
using S2IT.LocadoraGames.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace S2IT.LocadoraGames.Application.Services
{
    public class EnderecoAppService : IEnderecoAppService
    {
        private readonly IEnderecoRepository _enderecoRepository;
        private readonly ICidadeRepository _cidadeRepository;
        private readonly IMapper _mapper;
        public EnderecoAppService(
            IEnderecoRepository enderecoRepository, 
            ICidadeRepository cidadeRepository,
            IMapper mapper)
        {
            _enderecoRepository = enderecoRepository;
            _cidadeRepository = cidadeRepository;
            _mapper = mapper;

        }


        public IEnumerable<CidadeViewModel> ObterCidades()
        {
            var cidades = _cidadeRepository.GetAll();
            return _mapper.Map<IEnumerable<Cidade>, IEnumerable<CidadeViewModel>>(cidades);
        }

        public void Dispose()
        {
            _enderecoRepository.Dispose();
        }
    }
}
