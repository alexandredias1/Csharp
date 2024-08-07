Console.WriteLine("Escolha uma nota musical:");
Console.WriteLine("1 - Dó (C)");
Console.WriteLine("2 - Ré (D)");
Console.WriteLine("3 - Mi (E)");
Console.WriteLine("4 - Fá (F)");
Console.WriteLine("5 - Sol (G)");
Console.WriteLine("6 - Lá (A)");
Console.WriteLine("7 - Sí (B)");

int nota = Convert.ToInt32(Console.ReadLine());
string resposta;
string resposta1;
switch (nota)
{
    case 1:
        Console.WriteLine("Dó (C) tem frequência de aproximadamente 261.63 Hz");
        Console.WriteLine("Gostaria de saber a nota em sustenido?");
        resposta = Console.ReadLine();
        resposta1 = resposta.ToLower();
        if (resposta1 == "sim")
        {
            Console.WriteLine("Dó Sustenido (C#) tem frequência de aproximadamente 17.32 Hz");
        }
        break;
    case 2:
        Console.WriteLine("Ré (D) tem frequência de aproximadamente 293.66 Hz");
        Console.WriteLine("Gostaria de saber a nota em sustenido?");
        resposta = Console.ReadLine();
        resposta1 = resposta.ToLower();
        if (resposta1 == "sim")
        {
            Console.WriteLine("Ré Sustenido (D#) tem frequência de aproximadamente 19.44 Hz");
        }
        break;
    case 3:
        Console.WriteLine("Mi (E) tem frequência de aproximadamente 329.63 Hz");
        Console.WriteLine("Gostaria de saber a nota em sustenido?");
        resposta = Console.ReadLine();
        resposta1 = resposta.ToLower();
        if (resposta1 == "sim")
        {
            Console.WriteLine("Ré não tem nota sustenida");
        }
        break;
    case 4:
        Console.WriteLine("Fá (F) tem frequência de aproximadamente 349.23 Hz");
        Console.WriteLine("Gostaria de saber a nota em sustenido?");
        resposta = Console.ReadLine();
        resposta1 = resposta.ToLower();
        if (resposta1 == "sim")
        {
            Console.WriteLine("Fá Sustenido (F#) tem frequência de aproximadamente 23.12 Hz");
        }
        break;
    case 5:
        Console.WriteLine("Sol (G) tem frequência de aproximadamente 392.00 Hz");
        Console.WriteLine("Gostaria de saber a nota em sustenido?");
        resposta = Console.ReadLine();
        resposta1 = resposta.ToLower();
        if (resposta1 == "sim")
        {
            Console.WriteLine("Sol Sustenido (G#) tem frequência de aproximadamente 25.95 Hz");
        }
        break;
    case 6:
        Console.WriteLine("Lá (A) tem frequência de aproximadamente 27.50 Hz");
        Console.WriteLine("Gostaria de saber a nota em sustenido?");
        resposta = Console.ReadLine();
        resposta1 = resposta.ToLower();
        if (resposta1 == "sim")
        {
            Console.WriteLine("Lá Sustenido (A#) tem frequência de aproximadamente 29.13 Hz");
        }
        break;
    case 7:
        Console.WriteLine("Si (B) tem frequência de aproximadamente 30.86 Hz");
        Console.WriteLine("Gostaria de saber a nota em sustenido?");
        resposta = Console.ReadLine();
        resposta1 = resposta.ToLower();
        if (resposta1 == "sim")
        {
            Console.WriteLine("A nota Si não tem sustenido");
        }
        break;
    default:
        Console.WriteLine("Nota não reconhecida.");
        break;
}
Console.ReadKey();