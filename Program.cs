internal class Program
{
    private static void Main(string[] args)
    {
        var numero1 = 2;
        var numero2 = 3;

        var soma = numero1 + numero2;

        Console.WriteLine("A soma é igual a:", soma);
        Console.WriteLine($"A soma é igual a:", +soma);
        Console.WriteLine("Hello, World!");
    }
}