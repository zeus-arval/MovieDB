using Facade.Common;

namespace Facade
{
    public class MovieDetailsViewModel : BaseViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }
    }
}
