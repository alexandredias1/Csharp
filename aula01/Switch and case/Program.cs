Console.WriteLine("Selecione seu personagem 1- Bardo // 2 - Arqueiro // 3 - Guerreiro // 4 - Mago ");
int numero = Convert.ToInt32(Console.ReadLine());

switch (numero)
{
    case 1:
        Console.WriteLine("Você selecionou Bardo!");
        break;
    case 2:
        Console.WriteLine("Você selecionou Arqueiro!");
        break;
    case 3:
        Console.WriteLine("Você selecionou Guerreiro!");
        break;
    case 4:
        Console.WriteLine("Você selecionou Mago!");
        break;
    default:
        Console.WriteLine("Personagem invalido.");
        break;
}

Console.ReadKey();