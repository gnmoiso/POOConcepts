using POOConcepts.Core;
try
{

    var employee1 = new SalaryEmployee
    {
        id = 1010,
        FirstName = "Sandra",
        LastName = "Lopez",
        BornDate = new Date(1980, 4, 2),
        HireDate = new Date(2023, 2, 12),
        salary = 2000000m,
        IsActive = true
    };

    var employee2 = new HourlyEmployeecs
    {
        id = 2020,
        FirstName = "Hector",
        LastName = "Rosales",
        BornDate = new Date(1974, 9, 21),
        HireDate = new Date(2021, 2, 10),
        HourValue = 34679m,
        WorkingHours = 127f,
        IsActive = true
    };

    var employee3 = new CommissionEmployee
    {
        id = 3030,
        FirstName = "Vanesa",
        LastName = "Zapata",
        BornDate = new Date(1984, 4, 11),
        HireDate = new Date(2023, 11, 1),
        CommissionPercentaje = 0.03f,
        Sales = 527000000m,
        IsActive = true
    };


    var employees = new List<Employee> {employee1, employee2, employee3 };
    decimal total = 0;
    foreach (var employee in employees)
    {
        Console.WriteLine(employee);
        Console.WriteLine();
        total += employee.GetValueToPay();
    }
    Console.WriteLine("                         ====================");
    Console.WriteLine($"TOTAL:                  {total,20:C2}");


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
