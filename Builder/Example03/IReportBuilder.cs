namespace Builder.Example03
{
    public interface IReportBuilder
    {
        void SetTitle(string title);
        void SetDate();
        void SetSections(List<string> sections);
        void SetAuthor(string author);
        Report GetReport();
    }
}
