using AutoMapper;
using S2IT.LocadoraGames.Application.Interfaces;
using S2IT.LocadoraGames.Application.ViewModels;
using S2IT.LocadoraGames.Domain.Entities.Amigos;
using S2IT.LocadoraGames.Domain.Entities.Geografia;
using S2IT.LocadoraGames.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace S2IT.LocadoraGames.Application.Services
{
    public class AmigoAppService : IAmigoAppService
    {
        private readonly IMapper _mapper;
        private readonly IAmigoRepository _amigoRepository;

        public AmigoAppService(IMapper mapper, IAmigoRepository amigoRepository)
        {
            _mapper = mapper;
            _amigoRepository = amigoRepository;
        }

        public void Add(AmigoEnderecoViewModel amigoViewModel)
        {
            var amigo = _mapper.Map<AmigoEnderecoViewModel, Amigo>(amigoViewModel);
            var endereco = _mapper.Map<AmigoEnderecoViewModel, Endereco>(amigoViewModel);

            amigo.Endereco = endereco;

            _amigoRepository.Add(amigo);
            _amigoRepository.SaveChanges();
        }


        public IEnumerable<AmigoViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<Amigo>, IEnumerable<AmigoViewModel>>(_amigoRepository.GetAll());
        }

        public AmigoViewModel GetById(int id)
        {
            return _mapper.Map<Amigo, AmigoViewModel>(_amigoRepository.GetById(id));
        }

        public void Update(AmigoViewModel amigoViewModel)
        {
            var amigo = _mapper.Map<AmigoViewModel, Amigo>(amigoViewModel);
            _amigoRepository.Update(amigo);
            _amigoRepository.SaveChanges();

        }

        public void Remove(int id)
        {
            _amigoRepository.Remove(id);
            _amigoRepository.SaveChanges();
        }

        public void Dispose()
        {
            _amigoRepository.Dispose();
        }
    }
}
