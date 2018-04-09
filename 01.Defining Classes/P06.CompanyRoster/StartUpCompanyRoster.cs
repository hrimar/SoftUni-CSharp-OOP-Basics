using System;
using System.Collections.Generic;
using System.Linq;

class StartUpCompanyRoster
{
    static void Main()
    {
                // 100/100 - полезна задача!
                // мове да се реши и с Dictionary<department, List<employees>>()
        List<Department> departments = new List<Department>();

        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string name = input[0];
            decimal salary = decimal.Parse(input[1]);
            string position = input[2];
            string depName = input[3];
            int age = -1; 
            string email = "n/a";

            if (input.Length == 5)
            {
                // ако успее да парсе записва резулт в out, ako ne връща faulse!
                bool isAge = int.TryParse(input[4], out age);
                if (!isAge)
                {
                    email = input[4];
                    age = -1;
                }
            }
            else if (input.Length == 6)
            {
                age = int.Parse(input[5]);
                email = input[4];
            }


            if (!departments.Any(d => d.Name == depName))
            {
                Department department = new Department(depName);
                departments.Add(department);
            }

            var dep = departments.FirstOrDefault(d => d.Name == depName);

            var employee = new Employee(name, salary, position, age, email);
            dep.AddEmployee(employee);
        }

        var hiestAvgDepartment = departments.OrderByDescending(d => d.AverageSalary).First();

        Console.WriteLine($"Highest Average Salary: {hiestAvgDepartment.Name}");
        foreach (var emp in hiestAvgDepartment.Employees.OrderByDescending(e=>e.Salary))
        {
            Console.WriteLine($"{emp.Name} {emp.Salary:f2} {emp.Email} {emp.Age}");
        }

    }
}

