using System.Collections.Generic;
using System.Linq;

public class Department
{
    private List<Employee> employees;
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }


    public Department(string name)
    {
        this.Employees = new List<Employee>();
        this.Name = name; 
    }

    public List<Employee> Employees
    {
        get { return employees; }
      private set { employees = value; } // за да не се променя листа с Емплойс от другаде освен от метода за добавяне;
    }

    // за всеки департ. трeба взимаме само ср. заплата. Щом няма да ги сетваме, значи без set-ep!!
    public decimal AverageSalary => this.Employees.Select(e => e.Salary).Average();
    //{
    //    get
    //    {
    //        this.Employees.Select(e => e.Salary).Average();
    //    }
    //}


    public void AddEmployee(Employee employee)
    {
        this.Employees.Add(employee);
    }
}