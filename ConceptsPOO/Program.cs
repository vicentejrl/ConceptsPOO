using ConceptsPOO;

Console.WriteLine("Hello, World!");

try                 // Con Control+K+S saca el menú rodear con...
{
    Console.WriteLine(new Date(2000, 2, 29));
    Console.WriteLine(new Date(2023, 2, 29));
    Console.WriteLine(new Date(2022, 11, 31));
}
catch (Exception error)
{
    Console.Write(error.Message);
}