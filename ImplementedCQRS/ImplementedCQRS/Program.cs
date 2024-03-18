using ImplementedCQRS.Commands;
using ImplementedCQRS.Quries;
using ImplementedCQRS.Repositories;
using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {

        // Command the Emp Domain to save data
        var employeeCommand = new EmployeeCommands(new EmployeeCommandRepositories());
        employeeCommand.SaveEmployeeData(new ImplementedCQRS.Models.Employee
        {
            Id = 200,
            FirstName = "Jane",
            LastName = "Smith",
            Street = "150 Toronto Street",
            City = "Toronto",
            PostalCode = "j1j1j1",
            DateOfBirth = new DateTime(2002, 2, 2)
        });
        Console.WriteLine($"Employee data stored");
        // Query the Employee Domain to get data
        var employeeQuery = new EmployeeQuries(new EmployeeQuriesRepository());
        var employee = employeeQuery.FindByID(100);
        Console.WriteLine($"Employee ID:{employee.Id}, Name:{employee.FullName}, Address:{employee.Address}, Age:{employee.Age}");
        Console.ReadKey();


    }
}
