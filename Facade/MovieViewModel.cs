using Facade.Common;

namespace Facade
{
    /// <summary>
    /// View Model for Movie
    ///     Title: String
    ///     CategoryName: String
    ///     Year: Int
    ///     Rating: Int
    /// </summary>
    public class MovieViewModel : BaseViewModel
    {
        public string Title { get; set; }
        public string CategoryName { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }
    }
}
