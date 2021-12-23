using System.Collections.Generic;

namespace Infra.Common
{
    public interface IBaseRepo<TEntity, TData>
    {
        TData Get(int id);
        List<TEntity> Get();
    }
}
