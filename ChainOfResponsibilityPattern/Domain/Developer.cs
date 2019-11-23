namespace ChainOfResponsibilityPattern.Domain
{
    public class Developer : Employee
    {
        public Developer()
        {
            Next(new LeadDeveloper());
        }

        public override void Handle(Report report)
        {
            if (report.Type == ReportType.Severe || (report.Priority >= 4 && report.Priority < 8))
            {
                report.Status = ReportStatus.Resolved;
                report.Handler = nameof(Developer);
            }

            if (report.Status != ReportStatus.Resolved)
            {
                NextEmployee.Handle(report);
            }
        }
    }
}
