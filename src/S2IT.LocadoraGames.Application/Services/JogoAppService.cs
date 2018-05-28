using AutoMapper;
using S2IT.LocadoraGames.Application.Interfaces;
using S2IT.LocadoraGames.Application.ViewModels;
using S2IT.LocadoraGames.Domain.Entities.Jogos;
using S2IT.LocadoraGames.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace S2IT.LocadoraGames.Application.Services
{
    public class JogoAppService : IJogoAppService
    {
        private readonly IMapper _mapper;
        private readonly IJogoRepository _jogoRepository;

        public JogoAppService(IMapper mapper, IJogoRepository jogoRepository)
        {
            _mapper = mapper;
            _jogoRepository = jogoRepository;
        }

        public void Add(JogoViewModel jogoViewModel)
        {
            var jogo = _mapper.Map<JogoViewModel, Jogo>(jogoViewModel);

            _jogoRepository.Add(jogo);
            _jogoRepository.SaveChanges();
        }

        public IEnumerable<JogoViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<Jogo>, IEnumerable<JogoViewModel>>(_jogoRepository.GetAll());
        }

        public IEnumerable<JogoViewModel> GetGamesAndFriends()
        {
            return _mapper.Map<IEnumerable<Jogo>, IEnumerable<JogoViewModel>>(_jogoRepository.GetGamesAndFriends());
        }

        public JogoViewModel GetById(int id)
        {
            return _mapper.Map<Jogo, JogoViewModel>(_jogoRepository.GetById(id));
        }

        public void Remove(int id)
        {
            _jogoRepository.Remove(id);
            _jogoRepository.SaveChanges();
        }

        public void Update(JogoViewModel jogoViewModel)
        {
            var amigo = _mapper.Map<JogoViewModel, Jogo>(jogoViewModel);
            _jogoRepository.Update(amigo);
            _jogoRepository.SaveChanges();
        }

        public void Devolver(JogoViewModel jogoViewModel)
        {
            var jogo = _mapper.Map<JogoViewModel, Jogo>(jogoViewModel);
            _jogoRepository.Devolver(jogo);
            _jogoRepository.SaveChanges();
        }

        public IEnumerable<JogoViewModel> GetByTitle(string title)
        {
            return _mapper.Map<IEnumerable<Jogo>, IEnumerable<JogoViewModel>>(_jogoRepository.GetByTitle(title));
        }
    }
}
