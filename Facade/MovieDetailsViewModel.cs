using Facade.Common;

namespace Facade
{
    /// <summary>
    /// View model for Movie Details
    ///     Title: String
    ///     Description: String
    ///     Year: Int
    ///     Rating: Int
    /// </summary>
    public class MovieDetailsViewModel : BaseViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }
    }
}
