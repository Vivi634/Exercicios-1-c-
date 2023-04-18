internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");

        string name = Console.ReadLine();

        Console.WriteLine($"Seja bem vinda {name}!");

        Console.Write("Digite o ano do seu nascimento: ");

        int year = int.Parse(Console.ReadLine());

        int age = 2023 - year;

        Console.Write($"Você tem {age} anos.");

        if (age >= 18) Console.WriteLine("Você é maior de idade. ");

        else Console.WriteLine("Você é menor de idade.");

    }
}