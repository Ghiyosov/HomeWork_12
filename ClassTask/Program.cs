using ClassTask;

var employees = new List<Employee>()
{
    new Employee()
    {
        Id = 1,
        FirstName = "Alijon",
        LastName = "Zabirov",
        Age = 24, 
        PhoneNumber = "881667007",
        Salary = 4000
    },
    new Employee()
    {
        Id = 2,
        FirstName = "Nurullo",
        LastName = "Sulaymonov",
        Age = 30, 
        PhoneNumber = "908765432",
        Salary = 8000
    },
    new Employee()
    {
        Id = 3,
        FirstName = "Shodmon",
        LastName = "Inoyatzoda",
        Age = 26, 
        PhoneNumber = "987009988",
        Salary = 7800
    },
};
var employees2 = new List<Employee>()
{
    new Employee()
    {
        Id = 1,
        FirstName = "Alijon",
        LastName = "Zabirov",
        Age = 23, 
        PhoneNumber = "881667007",
        Salary = 4000
    },
    new Employee()
    {
        Id = 2,
        FirstName = "Nurullo",
        LastName = "Sulaymonov",
        Age = 32, 
        PhoneNumber = "908765432",
        Salary = 8000
    },
   
};
employees.AddRange(employees2);
employees.RemoveAll(p=>p.Age<25);
foreach (var item in employees)
{
    System.Console.WriteLine(item.Age);
}