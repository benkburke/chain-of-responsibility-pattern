namespace ChainOfResponsibilityPattern.Domain
{
    public class LeadDeveloper : Employee
    {
        public LeadDeveloper()
        {
            Next(null);
        }

        public override void Handle(Report report)
        {            
            if(report.Type == ReportType.Critical || report.Priority >= 8)
            {
                report.Status = ReportStatus.Resolved;
                report.Handler = nameof(LeadDeveloper);
            }

            if(report.Status != ReportStatus.Resolved)
            {
                NextEmployee.Handle(report);
            }
        }
    }
}
