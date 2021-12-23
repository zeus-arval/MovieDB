using System.Collections.Generic;

namespace Service.Common
{
    public interface IBaseService<TEntity>
    {
        List<TEntity> GetList();
    }
}
