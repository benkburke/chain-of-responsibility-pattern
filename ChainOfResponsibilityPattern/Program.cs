using System;
using ChainOfResponsibilityPattern.Domain;

namespace ChainOfResponsibilityPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            string keypress;

            do
            {
                // 0)
                // Display starting menu
                Console.Clear();

                Console.WriteLine("Chain of Responsibility Pattern -- Bug Report Context");
                Console.WriteLine();

                // 1)
                Console.WriteLine("Select report type:");

                Console.WriteLine();
                Console.WriteLine("1) Minimal");
                Console.WriteLine("2) Severe");
                Console.WriteLine("3) Critical");

                var type = Console.ReadKey().KeyChar.ToString();
                int.TryParse(type, out int reportType);
                Console.Clear();

                // 2)
                Console.WriteLine("Select priority:");

                var priority = Console.ReadKey().KeyChar.ToString();
                int.TryParse(priority, out int reportPriority);
                Console.Clear();

                var report = new Report
                {
                    Type = (ReportType)reportType - 1,
                    Priority = reportPriority
                };

                // 3)
                var employee = new QualityEngineer();
                employee.Handle(report);

                Console.WriteLine($"Thank you");
                Console.WriteLine();
                Console.WriteLine($"Your {report.Type} report, priority {report.Priority}, has been resolved by {report.Handler}");

                Console.WriteLine();
                Console.WriteLine("Menu ( M )");
                Console.WriteLine("Exit ( X )");

                keypress = Console.ReadKey().KeyChar.ToString();
            } while (keypress.ToLower() != "x");
        }
    }
}
