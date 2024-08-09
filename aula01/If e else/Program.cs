Console.WriteLine("Exemplo com 'if' e 'else':");

Console.Write("Digite um número: ");
double numero = Convert.ToDouble(Console.ReadLine());

if (numero % 3 == 0)
{
    double quintoplo = numero * 5;
    Console.WriteLine($"O quintoplo do valor é: {quintoplo}");
}
else
{
    double triplo = numero * 3;
    Console.WriteLine($"O triplo do valor é: {triplo}");
}

// Mantém a janela do console aberta
Console.ReadKey();
