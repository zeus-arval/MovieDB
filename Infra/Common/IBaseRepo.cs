using System.Collections.Generic;

namespace Infra.Common
{
    public interface IBaseRepo<T>
    {
        T Get(int id);
        List<T> Get();
    }
}
