namespace sortstring.Models
{
    public class SortModel
    {
        public List<string> Sortoption { get; set; }
        public string Sort { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }

        public SortModel()
        {
            Sortoption = new List<string> { "Bubble Sort", "Quick Sort"/*, "Merge Sort"*/ };
            Sort = string.Empty;
            Input = string.Empty;
            Output = string.Empty;
        }
    }
}

