using System;

namespace Employee_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Toy = new Employee("Toy?", new DateTime(2004, 3, 13),"Student",13);
            Console.WriteLine(Employee.GetNumOfEmployees());
            Toy.SetJob("Plumber");
            Toy.SetSalary(6);
            Toy.SetName("Mrs Toy");
            Console.WriteLine(Toy.GetMonthlySalary());
            Console.WriteLine(Toy.isBirthday());
            Console.WriteLine(Toy.GetYearsUntilRetirement());
            Console.WriteLine(Toy.GetInformation());

            Employee Ankit = new Employee("Ankit", new DateTime(2004, 10, 25), "Pilot", 1231);
            Console.WriteLine(Employee.employeeCount);
        }
    }
}
