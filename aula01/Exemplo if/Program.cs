Console.WriteLine("Exemplo com 'if':");

Console.Write("Digite o primerio número: ");
int numero = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int numero2 = Convert.ToInt32(Console.ReadLine());

int soma = numero + numero2;

if (soma > 70)
{
    Console.WriteLine("Financiamento Aprovado.");
}
else
{
    Console.WriteLine("Financiamento reprovado.");
}

Console.ReadKey();


Console.ReadKey();
