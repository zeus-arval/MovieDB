using Data.Common;

namespace Data
{
    public class Movie : BaseData
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public int CategoryInt { get; set; }
    }
}
