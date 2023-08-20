internal class Program
{
    private static void Main(string[] args)
    {
        string nome, sobrenome;
        Console.Write("Digite seu nome..... ");
        nome = Console.ReadLine();
        Console.Write("Digite seu sobrenome..... ");
        sobrenome = Console.ReadLine();
        Console.WriteLine($"{nome}{sobrenome}");
        Console.WriteLine($"{sobrenome.ToUpper()}, {nome}");
    }
}