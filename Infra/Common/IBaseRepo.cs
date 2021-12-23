using System.Collections.Generic;

namespace Infra.Common
{
    public interface IBaseRepo<TEntity, TDetails>
    {
        TDetails Get(int id);
        List<TEntity> Get();
    }
}
