static void Main(string[] args)
{
    Console.WriteLine("Escreva uma palavra: ");
    string frase = Console.ReadLine().ToUpper();
    int cont = 1;

    for (int i = 0; i < frase.Length; i++)
    {
        if (' ' == frase[i] )
        {
            cont++;
        }

    }
    Console.WriteLine("Frase: " + frase);
    Console.WriteLine("Número de palavras: "+ cont);
}
