using DevExpress.DataAccess.ObjectBinding;
using System.Collections.Generic;
using System.ComponentModel;
// ...
public class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }
}

[DisplayName("Employees")]
[HighlightedClass]
public class EmployeeDataSource
{
    private string department;
    private List<Employee> management = new List<Employee>() {
        new Employee() {
            Name = "Ana Trujillo",
            Position = "CEO"
        },
        new Employee() {
            Name = "Andrew Fuller",
            Position = "Vice President, Sales"
        }
    };
    private List<Employee> financial = new List<Employee>() {
        new Employee() {
            Name = "Nancy Davolio",
            Position = "Accountant"
        },
        new Employee() {
            Name = "Maria Anders",
            Position = "Accountant"
        }
    };
    private List<Employee> sales = new List<Employee>() {
        new Employee() {
            Name = "Antonio Moreno",
            Position = "Sales Representative"
        },
        new Employee() {
            Name = "Thomas Hardy",
            Position = "Sales Representative"
        },
        new Employee() {
            Name = "Christina Berglund",
            Position = "Order Administrator"
        },
        new Employee() {
            Name = "Frédérique Citeaux",
            Position = "Marketing Manager"
        },
        new Employee() {
            Name = "Hanna Moos",
            Position = "Sales Representative"
        }
    };
    public EmployeeDataSource()
    {
        this.department = "Management";
    }

    [HighlightedMember]
    public EmployeeDataSource(string department)
    {
        this.department = department;
    }

    [HighlightedMember]
    public IEnumerable<Employee> GetEmployeeList(int recordCount)
    {
        List<Employee> employees = new List<Employee>();
        if (this.department == "Management")
            employees = this.management;
        if (this.department == "Financial")
            employees = this.financial;
        if (this.department == "Sales")
            employees = this.sales;
        foreach (var employee in employees)
            if (recordCount-- > 0)
                yield return employee;
    }
}
