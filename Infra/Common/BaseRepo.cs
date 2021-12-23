using Data.Common;
using Domain.Common;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Common
{
    public abstract class BaseRepo<TEntity, TEntityDetails, TData> : IBaseRepo<TEntity, TEntityDetails>
        where TData : class, IBaseData, new()
        where TEntity : class, IBaseEntity, new()
        where TEntityDetails : class, IBaseEntity, new()
    {
        protected internal readonly List<TData> dataList;
        public BaseRepo(List<TData> list = null)
        {
            dataList = list;
        }
        public TEntityDetails Get(int id)
        {
            if (id < 0) return null;
            if (dataList is null) return null;
            var dataObject = dataList?.FirstOrDefault(data => data?.Id == id);
            return DetailsToEntity(dataObject);
        }
        public List<TEntity> Get() => dataList.Select(ToEntity).ToList();
        protected internal abstract TEntity ToEntity(TData d);
        protected internal abstract TEntityDetails DetailsToEntity(TData d);
    }
}
