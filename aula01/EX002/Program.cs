using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número inteiro: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int soma = 0;

        for (int i = 1; i <= N; i++)
        {
            soma += i;
        }

        Console.WriteLine($"A soma de todos os números de 1 até {N} é: {soma}");
    }
}
Console.ReadKey();