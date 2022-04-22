using ConceptsPOO;

Console.WriteLine("Hello, World!");

try                 // Con Control+K+S saca el menú rodear con...
{
    Console.WriteLine(new Date(2000, 2, 29));
    Console.WriteLine(new Date(2023, 2, 28));
    Console.WriteLine(new Date(2022, 11, 30));

    Employee employee1 = new SalaryEmployee()
    {
        Id = 1010,
        FirsName = "Vicente",
        LastName = "Romero",
        BirthDate = new Date(1968, 03, 26),
        HiringDate = new Date(2019, 04, 09),
        IsActive = true,
        Salary = 10254.55M  //Para el tipo de dato Decimal que necesitemos manejar dinero debe terminar en M
    };

    //Console.WriteLine(employee1);

    Employee employee2 = new CommissionEmployee()
    {
        Id = 1020,
        FirsName = "Adilianes",
        LastName = "Diaz",
        BirthDate = new Date(1992, 03, 26),
        HiringDate = new Date(2019, 04, 09),
        IsActive = true,
        CommissionPercentaje = 0.25F,
        Sales = 50000M
    };

    //Console.WriteLine(employee2);

    Employee employee3 = new HourlyEmployee()
    {
        Id = 1030,
        FirsName = "Teresa",
        LastName = "López",
        BirthDate = new Date(1982, 03, 26),
        HiringDate = new Date(2019, 04, 09),
        IsActive = true,
        Hours = 18,
        HourValue = 50
    };

    //Console.WriteLine(employee3);

    Employee employee4 = new BaseCommissionEmployee()
    {
        Id = 1040,
        FirsName = "Marisela",
        LastName = "Diaz",
        BirthDate = new Date(1995, 03, 26),
        HiringDate = new Date(2021, 04, 09),
        IsActive = true,
        Base = 5000.50M,
        CommissionPercentaje = 0.15F,
        Sales = 45000M
    };

    //Console.Write(employee4);

    ICollection<Employee> employees = new List<Employee>()
    { 
        employee1, employee2, employee3, employee4 
    };

    decimal payroll = 0;

    foreach (Employee employee in employees)
    {
        Console.WriteLine(employee);
        payroll += employee.GetValueToPay();
    }

    Console.WriteLine("                                 ===============");
    Console.WriteLine($"Total                            {$"{payroll:C2}",15}");

    Invoice invoice1 = new Invoice()
    {
        Id = 1,
        Description = "Iphone 13",
        Price = 25000,
        Quantity = 2
    };

    Invoice invoice2 = new Invoice()
    {
        Id = 2,
        Description = "Iphone 11",
        Price = 19000,
        Quantity = 3
    };

    Console.WriteLine(invoice1);

    Console.WriteLine(invoice2);
}
catch (Exception error)
{
    Console.Write(error.Message);
}