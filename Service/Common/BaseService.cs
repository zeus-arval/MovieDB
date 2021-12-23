using Data.Common;
using Domain.Common;
using Domain.Common.Aids;
using Facade.Common;
using Infra.Common;
using System.Collections.Generic;
using System.Linq;

namespace Service.Common
{
    /// <summary>
    /// Base Service class 
    ///     Contains a list of domains
    ///     Gets a list of View Models
    ///     Gets a list of domains
    /// </summary>
    public class BaseService<TEntity, TDetails, TData, TView> : IBaseService<TView>
        where TEntity : class, IBaseEntity, new()
        where TDetails : class, IBaseEntity, new()
        where TData : class, IBaseData, new()
        where TView : BaseViewModel, new()
    {
        protected internal IBaseRepo<TEntity, TData> _repo;
        public BaseService() : this(null) { }
        public BaseService(IBaseRepo<TEntity, TData> repo)
        {
            _repo = repo;
        }

        protected internal List<TEntity> Items { get; set; }
        public List<TView> GetList()
        {
            if (Items is null) GetItemsFromRepo(); 
            return Items.Select(x => Copier.CopyMembers(x, new TView())).ToList();
        }
        protected void GetItemsFromRepo()
        {
            if (_repo is null) return;
            Items = _repo.Get();
        }
    }
}
