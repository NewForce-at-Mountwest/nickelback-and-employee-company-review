using System;
using System.Collections.Generic;

// Create a custom type for Company. A company has the following properties.
// Date founded (DateTime)
// Company name (string)
// Employees (List<Employee>)

// The Company class should also have a ListEmployees() method which outputs the name of each employee to the console.

namespace iteration_review{
    class Company{

    public Company(string nameParam, DateTime createdOnParam){
        Name = nameParam;
        CreatedOn = createdOnParam;
    }
    public string Name { get; }
    public DateTime CreatedOn { get; }

    // Create a public property for holding a list of current employees

    private List<Employee> _EmployeeList { get; set;} = new List<Employee>();

    public void HireEmployee(Employee newHire){
        _EmployeeList.Add(newHire);
    }

    public void ListEmployees(){
        foreach(Employee currentEmployee in _EmployeeList){
            string employeeName = $"{currentEmployee.FirstName} {currentEmployee.LastName}";
            string jobTitle = currentEmployee.Title;
            DateTime startDate = currentEmployee.StartDate;
            string companyName = Name;

            Console.WriteLine($"{employeeName} has worked at {companyName} as a {jobTitle} since {startDate}.");

        }
    }


    }
}