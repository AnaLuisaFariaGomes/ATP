static void Main(string[] args)
{
    Console.WriteLine("Digite uma frase com pelo menos 50 caracteres: ");
    string frase = Console.ReadLine();

    Console.WriteLine("Digite uma string com exatamente 2 caracteres: ");
    string busca = Console.ReadLine();

    if (frase.Length >= 50 && busca.Length == 2)
    {
        int cont = 0;
        for (int i = 0; i <= frase.Length - 2; i++)
        {
            if (frase.Substring(i, 2) == busca)
            {
                cont++;
            }
        }
        Console.WriteLine($"A string '{busca}' aparece {cont} vezes na frase.");
    }
    else
    {
        if (frase.Length < 50)
        {
            Console.WriteLine("A frase deve conter pelo menos 50 caracteres.");
        }

        if (busca.Length != 2)
        {
            Console.WriteLine("A string deve conter exatamente 2 caracteres.");
        }
    }
}
