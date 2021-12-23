using Data.Common;
using Domain.Common.Aids;

namespace Domain.Common
{
    /// <summary>
    /// Base Domain class for getting information from MoviesList using POCO models
    /// </summary>
    public abstract class BaseEntity<TData> : IBaseEntity
        where TData : class, IBaseData, new()
    {
        protected readonly TData data;
        public BaseEntity() : this(null) { }
        public BaseEntity(TData d) => data = d;
        public TData Data => Copier.CopyMembers(data, new TData()) ?? new TData();
        public int Id => Data?.Id ?? int.MinValue;
    }
}
