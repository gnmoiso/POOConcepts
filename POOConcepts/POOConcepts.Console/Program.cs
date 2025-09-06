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
        salary = 2315000m,
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

    var employee4 = new BaseCommissionEmployee
    {
        id = 4040,
        FirstName ="Pedro",
        LastName = "Salazar",
        BornDate = new Date(1984, 4, 11),
        HireDate = new Date(2023, 11, 1),
        CommissionPercentaje = 0.015f,
        Sales = 89568000,
        Salary = 500000m,
        IsActive = true
    };

    var invoice1 = new Invoice
    {
        
        id = 1,
        Description = "Computer Asus R55",
        Price = 4500000m,
        Quantity = 3
    };

    var invoice2 = new Invoice
    {

        id = 1,
        Description = "Avocado",
        Price = 5321m,
        Quantity = 5.68f
    };

    var invoice3 = new Invoice
    {

        id = 1,
        Description = "Chairs",
        Price = 823456m,
        Quantity = 5
    };

    var items = new List<IPay> {employee1, employee2, employee3, employee4, invoice1, invoice2, invoice3 };
    decimal total = 0;
    foreach (var item in items)
    {
        Console.WriteLine(item);
        Console.WriteLine();
        total += item.GetValueToPay();
    }
    Console.WriteLine("                         ====================");
    Console.WriteLine($"TOTAL:                  {total,20:C2}");


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
