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

    Console.WriteLine(employee1);

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

    Console.WriteLine(employee2);
}
catch (Exception error)
{
    Console.Write(error.Message);
}