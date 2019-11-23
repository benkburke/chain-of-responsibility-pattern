namespace ChainOfResponsibilityPattern.Domain
{
    public class Report
    {
        public Report()
        {
            Status = ReportStatus.New;
        }

        public ReportType Type { get; set; }

        public int Priority { get; set; }

        public ReportStatus Status { get; set; }

        public string Handler {get; set;}
    }
}
