using System.Security.Cryptography;

namespace ClassTask;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string PhoneNumber { get; set; }
    public decimal Salary { get; set; }
    public Employee(){}
    public Employee(string name, string surname)
    {
        FirstName = name;
        LastName = surname;

    }
    int GetBirthYear()
    {
        return 2024-Age;
    }


}
