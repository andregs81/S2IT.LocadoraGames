using S2IT.LocadoraGames.Domain.Interfaces.Repository;
using S2IT.LocadoraGames.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace S2IT.LocadoraGames.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;

        public ServiceBase(IRepository<TEntity> repository)
        {
            _repository = repository;
        }
        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(int obj)
        {
            _repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
