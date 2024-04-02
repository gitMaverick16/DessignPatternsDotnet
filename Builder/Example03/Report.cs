namespace Builder.Example03
{
    public class Report
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public List<string> Sections { get; set; }
        public string Author { get; set; }
        public void DisplayReport()
        {
            Console.WriteLine("Report info:");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Date: {Date}");
            var counterSection = 1;
            foreach(var section in Sections)
            {
                Console.WriteLine($"Section {counterSection}: {section}");
                counterSection++;
            }
            Console.WriteLine($"Author: {Author}");
        }
    }
}
