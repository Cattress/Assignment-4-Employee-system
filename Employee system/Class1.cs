using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_system
{
    class Employee
    {
        private string name;
        private int age;
        private DateTime dob;
        private string job;
        private double salary;

        private static int employeeCount();
        private static int retirementAge = 65;

        public Employee(string -name, DateTime -dob, string -job, double -salary)
        {
            name = -name;
            job = -job;
            salary = -salary;
            dob = -dob;

            //employeeCount = employeeCount+1
            //employeeCount += 1;       same as above
            employeeCount++; //same as above

        }
        public double GetMonthlySalary()
        {
            double MonthlySalary = salary / 12;
            return MonthlySalary;
        }

        public bool isBirthday()
        {
            int month = dob.Month;
            int day = dob.Day;

            if (month == DateTime.Now.Month && day == DateTime.Now.Day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SetAge()
        {        
                            // 2021 - 2004 = 17
            age = DateTime.Now.Year - dob.Year;
        }

        public int GetYearsUntilRetirement()
        {
            SetAge();
                                                //65 - 17
            int YearsUntilRetirement = retirementAge - age;
            return YearsUntilRetirement;
        }
        public string GetInformation()
        {
            string information = "Name: "+name +" Age: " +age + " Job: "+job + " Salary: "+salary;

        }
    }
}
