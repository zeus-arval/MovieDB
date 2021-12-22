using Data.Common;

namespace Data
{
    public class MovieData : BaseData
    {
        public string Title { get; set; }
        public string Description { get; set; }     
        public int Year { get; set; }
        public int Rating { get; set; }             // Based on 10-point grading scale
        public int CategoryId { get; set; }    
    }
}
