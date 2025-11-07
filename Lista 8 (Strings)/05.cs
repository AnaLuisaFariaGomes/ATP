static bool Palindromo(string palavra)
{
    int cont = 0;
    bool teste;

    for (int i = palavra.Length - 1, j = 0; i >= 0; i--, j++)
    {
        if (palavra[i] == palavra[j])
        {
            cont++;
        }
    }

    if (cont == palavra.Length)
    {
        teste = true;
    }
    else
    {
        teste = false;
    }
    return teste;
}
static void Main(string[] args)
{
    Console.WriteLine("Escreva uma palavra: ");
    string palavra = Console.ReadLine().ToUpper();
    bool result = Palindromo(palavra);
    Console.WriteLine(result);
}
