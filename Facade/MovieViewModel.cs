using Facade.Common;

namespace Facade
{
    public class MovieViewModel : BaseViewModel
    {
        public string Title { get; set; }
        public string CategoryName { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }
    }
}
