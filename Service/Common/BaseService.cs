using Domain.Common;
using Infra.Common;
using System.Collections.Generic;

namespace Service.Common
{
    public class BaseService<TEntity, TDetails> : IBaseService<TEntity>
        where TEntity : class, IBaseEntity, new()
    {
        protected internal IBaseRepo<TEntity> _repo;
        public BaseService() : this(null) { }
        public BaseService(IBaseRepo<TEntity> repo)
        {
            _repo = repo;
        }

        protected internal List<TEntity> Items { get; set; }
        public List<TEntity> GetList()
        {
            if (Items is null) GetItemsFromRepo(); 
            return Items;
        }
        private void GetItemsFromRepo()
        {
            if (_repo is null) return;
            Items = _repo.Get();
        }
    }
}
