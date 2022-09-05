using ReportGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IReportPrinter
    {
        public void PrintReport(List<Employee> employees);

    }
}
