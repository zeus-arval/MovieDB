using System.Collections.Generic;

namespace Infra.Common
{
    public interface IBaseRepo<TEntity>
    {
        TEntity Get(int id);
        List<TEntity> Get();
    }
}
