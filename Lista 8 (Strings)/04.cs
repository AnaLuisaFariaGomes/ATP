static void Main(string[] args)
{
    Console.WriteLine("Escreva uma palavra: ");
    string palavra = Console.ReadLine().ToUpper();

    for (int i = palavra.Length - 1; i >= 0; i--)
    {
        Console.Write(palavra[i]);
    }
}
