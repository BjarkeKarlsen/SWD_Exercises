using ReportGenerator;

namespace ClassLibrary
{
    public class SalaryFirstReportPrinter : IReportPrinter
    {
        public void PrintReport(List<Employee> employees)
        {
            Console.WriteLine("Salary-first report");
            foreach (var e in employees)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Salary: {0}", e.Salary);
                Console.WriteLine("Name: {0}", e.Name);
                Console.WriteLine("------------------");
            }
        }
    }

}