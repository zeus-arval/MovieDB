using Data.Common;

namespace Data
{
    /// <summary>
    /// Poco class for Category
    ///     Name: string
    ///     Id: Int (Principal Key)
    /// </summary>
    public class CategoryData : BaseData
    {
        public string Name { get; set; }
    }
}
