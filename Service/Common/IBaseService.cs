using System.Collections.Generic;

namespace Service.Common
{
    public interface IBaseService<TView>
    {
        List<TView> GetList();
    }
}
