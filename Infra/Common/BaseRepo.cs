using Data.Common;
using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Common
{
    public abstract class BaseRepo<TEntity, TData> : IBaseRepo<TEntity>
        where TData : class, Data.Common.IBaseData, new()
        where TEntity : class, Domain.Common.IBaseData, new()
    {
        protected internal readonly List<TData> dataList;
        public BaseRepo(List<TData> list = null)
        {
            dataList = list;
        }
        public TEntity Get(int id)
        {
            if (id < 0) return null;
            if (dataList is null) return null;
            var dataObject = dataList?.FirstOrDefault(data => data?.Id == id);
            return ToEntity(dataObject);
        }

        public List<TEntity> Get() => dataList.Select(ToEntity).ToList();
        protected internal abstract TEntity ToEntity(TData d);
    }
}
