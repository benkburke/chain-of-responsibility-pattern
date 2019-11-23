namespace ChainOfResponsibilityPattern.Domain
{
    public class QualityEngineer : Employee
    {
        public QualityEngineer()
        {
            Next(new Developer());
        }

        public override void Handle(Report report)
        {
            report.Status = ReportStatus.InProgress;

            if(report.Type == ReportType.Minimal || report.Priority < 4)
            {
                report.Status = ReportStatus.Resolved;
                report.Handler = nameof(QualityEngineer);
            }

            if(report.Status != ReportStatus.Resolved)
            {
                NextEmployee.Handle(report);
            }
        }
    }
}
