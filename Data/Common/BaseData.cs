namespace Data.Common
{
    /// <summary>
    /// Base POCO class
    ///     Id: Int(Principal Key)
    /// </summary>
    public abstract class BaseData : IBaseData
    {
        public int Id { get; set; }
    }
}
