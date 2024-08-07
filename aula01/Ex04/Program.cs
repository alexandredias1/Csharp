Console.WriteLine("Selecione uma cor entre:\n 1- Vermelho \n2 - Azul \n3 - Amarelo \n4 - Roxo ");
int cor = Convert.ToInt32(Console.ReadLine());

switch (cor)
{
    case 1:
        Console.WriteLine("Vermelho em inglês é 'Red'");
        break;
    case 2:
        Console.WriteLine("Azul em inglês é 'Blue'");
        break;
    case 3:
        Console.WriteLine("Amarelo em inglês é 'Yellow'");
        break;
    case 4:
        Console.WriteLine("Roxo em inglês é 'Purple'");
        break;
    default:
        Console.WriteLine("Cor inválida.");
        break;
}

Console.ReadKey();