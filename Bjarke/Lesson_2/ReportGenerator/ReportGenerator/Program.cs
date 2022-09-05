using System;
using ClassLibrary;

var db = new EmployeeDB();
var salaryReportPrinter = new SalaryFirstReportPrinter();
var firstNameReportPrinter = new NameFirstReportPrint();

// Add some employees
db.AddEmployee(new Employee("Anne", 3000));
db.AddEmployee(new Employee("Berit", 2000));
db.AddEmployee(new Employee("Christel", 1000));

var reportGenerator = new ReportGeneratorClass(db);

// Create a default (name-first) report
reportGenerator.CompileReport(firstNameReportPrinter);

Console.WriteLine("");
Console.WriteLine("");

// Create a salary-first report

reportGenerator.CompileReport(salaryReportPrinter);

