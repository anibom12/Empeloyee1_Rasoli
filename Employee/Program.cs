using EmployeeService;
using System;

Console.WriteLine("Enter your Firstname:");
string? firstname = Console.ReadLine();

Console.WriteLine("Enter your LastName:");
string? lastname = Console.ReadLine();

Console.WriteLine("Enter the type of Employee:");
string? type = Console.ReadLine();

Console.WriteLine("Enter your NationalCode:");
string? nationalcode = Console.ReadLine();

Console.WriteLine("Enter your base salary:");
double basesalary = double.Parse(Console.ReadLine());

Console.WriteLine("Enter your level:");
int level = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the total hours:");
int totalhours = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the extra time:");
int extratime = int.Parse(Console.ReadLine());

Employee person = EmployerFactory.CreateEmployee(type, nationalcode);
person.SetData(basesalary, level, totalhours, extratime);
person.FirstName = firstname;
person.LastName = lastname;

Console.WriteLine(person);
