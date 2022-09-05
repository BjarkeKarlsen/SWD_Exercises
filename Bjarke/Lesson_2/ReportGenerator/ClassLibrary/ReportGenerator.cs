using System;
using System.Collections.Generic;

namespace ClassLibrary
{

    public class ReportGeneratorClass
    {
        private readonly EmployeeDB _employeeDb;

        // Generate report responsibility
        public ReportGeneratorClass(EmployeeDB employeeDb)
        {

            if (employeeDb == null) throw new ArgumentNullException("employeeDb");
            _employeeDb = employeeDb;
        }


        // Compile report responsibility
        public void CompileReport(IReportPrinter reportPrinter)
        {

            //reportOutputFormat.SetOutputFormat();
            var employees = new List<Employee>();
            Employee employee;

            _employeeDb.Reset();

            // Get all employees from database
            while ((employee = _employeeDb.GetNextEmployee()) != null)
            {
                employees.Add(employee);
            }

            // All employees collected - let's output them
            reportPrinter.PrintReport(employees);
        }





    }
}