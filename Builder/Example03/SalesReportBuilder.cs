namespace Builder.Example03
{
    public class SalesReportBuilder : IReportBuilder
    {
        private Report _report;
        public SalesReportBuilder()
        {
            _report = new Report();    
        }
        public void SetAuthor(string author)
        {
            _report.Author = author;
        }

        public void SetDate()
        {
            _report.Date = DateTime.Now;   
        }

        public void SetSections(List<string> sections)
        {
            _report.Sections = sections;
        }

        public void SetTitle(string title)
        {
            _report.Title = title;
        }

        public Report GetReport()
        {
            return _report;
        }
    }
}
